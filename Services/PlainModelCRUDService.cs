using FreeStripService.Data;
using FreeStripService.Model;
using FreeStripService.Repositories.Abstract;
using FreeStripService.Results;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStripService
{
    /// <summary>
    /// Сервис для выполнения операций CRUD для моделей самолета
    /// </summary>
    public class PlainModelCRUDService : PlainModelCRUD.PlainModelCRUDBase
    {
        /// <summary>
        /// Репозиторий для Модели самолета
        /// </summary>
        private readonly IPlainModelRepository _PlainModelRepository;

        /// <summary>
        /// 
        /// </summary>
        private readonly ProtoModelConverter _Converter;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="plainModelRepository">Репозиторий для Модели самолета</param>
        /// <param name="converter"></param>
        public PlainModelCRUDService(IPlainModelRepository plainModelRepository, ProtoModelConverter converter)
        {
            _PlainModelRepository = plainModelRepository ?? throw new ArgumentNullException(nameof(plainModelRepository));
            _Converter = converter ?? throw new ArgumentNullException(nameof(converter));
        }

        /// <summary>
        /// Метод для получения информации обо всех самолетах
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context">информация о контексте,в котором работает сервер</param>
        /// <returns></returns>
        public override Task<PlainModelListResponse> SelectAll(Empty request, ServerCallContext context)
        {
            var plainModelList = _PlainModelRepository.SelectAll();

            var plainModelRequestList = new List<PlainModelRequest>();

            foreach (var plainModel in plainModelList)
            {
                plainModelRequestList.Add(_Converter.Convert(plainModel));
            }

            var plainModelListResponse = new PlainModelListResponse();

            plainModelListResponse.Items.Add(plainModelRequestList);

            return Task.FromResult(plainModelListResponse);
        }

        /// <summary>
        /// Метод добавления модели самолета в БД
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context">информация о контексте,в котором работает сервер</param>
        /// <returns></returns>
        public override Task<OperationResponse> Add(PlainModelRequest request, ServerCallContext context)
        {
            var plainModel = _Converter.Convert(request);

            var dbOperationResult = _PlainModelRepository.Add(plainModel);

            var response = GetOperationResponse(dbOperationResult);

            return Task.FromResult(response);
        }

        /// <summary>
        /// Метод редактирования модели самолета в БД
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context">информация о контексте,в котором работает сервер</param>
        /// <returns></returns>
        public override Task<OperationResponse> Update(PlainModelRequest request, ServerCallContext context)
        {
            var plainModel = _Converter.Convert(request);

            var dbOperationResult = _PlainModelRepository.Update(plainModel);

            var response = GetOperationResponse(dbOperationResult);

            return Task.FromResult(response);
        }

        /// <summary>
        /// Метод удаления модели самолета в БД
        /// </summary>
        /// <param name="request">фильтр на удаляемые самолеты</param>
        /// <param name="context">информация о контексте,в котором работает сервер</param>
        /// <returns></returns>
        public override Task<OperationResponse> Delete(PlainModelFilterRequest request, ServerCallContext context)
        {
            var result = _PlainModelRepository.Delete(request.PlainModelId);

            var response = GetOperationResponse(result);

            return Task.FromResult(response);
        }
        
        /// <summary>
        /// Вспомогательный метод для формирования ответа сервиса
        /// </summary>
        /// <param name="executionResult">результат работы метода сервиса</param>
        /// <returns>ответ сервиса</returns>
        private OperationResponse GetOperationResponse(ExecutionResult executionResult)
        {
            var response = new OperationResponse();

            if (executionResult.Success)
            {
                response.SuccessResponse = new SuccessResponse();
            }
            else
            {
                response.ErrorResponse = new ErrorResponse 
                { 
                    ErrorText = executionResult.ErrorMessage 
                };
            }

            return response;
        }
    }
}
