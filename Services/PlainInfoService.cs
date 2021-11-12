using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using FreeStripService.Repositories.Abstract;
using FreeStripService.Weather.Abstract;
using FreeStripService.Data;

namespace FreeStripService
{
    /// <summary>
    /// Сервис для расчета информации о взлете и посадке
    /// </summary>
    public class PlainInfoService : PlainInfo.PlainInfoBase
    {
        /// <summary>
        /// Влияние погодных условий
        /// </summary>
        private readonly IWeatherInfluence _WeatherInfluence;

        /// <summary>
        /// Репозиторий для Модели самолета
        /// </summary>
        private readonly IPlainModelRepository _PlainModelRepository;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="weatherInfluence">Влияние погодных условий</param>
        /// <param name="plainModelRepository">Репозиторий для Модели самолета</param>
        public PlainInfoService(IWeatherInfluence weatherInfluence, IPlainModelRepository plainModelRepository)
        {
            _WeatherInfluence = weatherInfluence ?? throw new ArgumentNullException(nameof(weatherInfluence));

            _PlainModelRepository = plainModelRepository ?? throw new ArgumentNullException(nameof(plainModelRepository));
        }

        /// <summary>
        /// Метод получает информацию об условиях, необходимых для посадки заданной модели самолета
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<PlainPreparationReply> GetLandingInfo(PlainPreparationRequest request, ServerCallContext context)
        {
            var plainModel = _PlainModelRepository.SelectById(request.PlainModel);

            var stripLength = _WeatherInfluence.CalculateLandStripLength(plainModel.LandStripLength, request.CalculatedPressure, request.CalculatedTemp);

            var reply = new PlainPreparationReply
            {
                PrepareMinutes = plainModel.PlainType.PickUpMinutes,
                StripLength = stripLength
            };

            return Task.FromResult(reply);
        }

        /// <summary>
        /// Метод получает информацию об условиях, необходимых для взлета заданной модели самолета
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task<PlainPreparationReply> GetTakeOffInfo(PlainPreparationRequest request, ServerCallContext context)
        {
            var plainModel = _PlainModelRepository.SelectById(request.PlainModel);

            var stripLength = _WeatherInfluence.CalculateTakeOffStripLength(plainModel.TakeOffStripLength, request.AltitudeTemp, request.Altitude, request.CalculatedTemp);

            var reply = new PlainPreparationReply
            {
                PrepareMinutes = plainModel.PlainType.PickOffMinutes,
                StripLength = stripLength
            };

            return Task.FromResult(reply);
        }
    }
}
