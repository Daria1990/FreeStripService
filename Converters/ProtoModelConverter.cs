using FreeStripService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStripService
{
    /// <summary>
    /// Класс для преобразования типов в базе данных в типы protobuf и наоборот
    /// </summary>
    public class ProtoModelConverter
    {
        /// <summary>
        /// Метод переводит модель самолета из БД в proto запрос
        /// </summary>
        /// <param name="model">Модель самолета в БД</param>
        /// <returns>proto запрос для модели самолета</returns>
        public PlainModelRequest Convert(PlainModel model)
        {
            if (model ==null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            return new PlainModelRequest
            {
                Id = model.Id,
                LandStripLength = model.LandStripLength,
                Name = model.Name,
                TakeOffStripLength = model.TakeOffStripLength,
                PlainTypeId = model.PlainTypeId
            };
        }

        /// <summary>
        /// Метод переводит proto запрос в модель самолета для БД
        /// </summary>
        /// <param name="request">proto запрос для модели самолета<</param>
        /// <returns>proto запрос для модели самолета</returns>
        public PlainModel Convert(PlainModelRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var plainModel = new PlainModel
            {
                LandStripLength = request.LandStripLength,
                Name = request.Name,
                TakeOffStripLength = request.TakeOffStripLength,
                PlainTypeId = request.PlainTypeId,
            };

            if (request.Id != 0)
            {
                plainModel.Id = request.Id;
            }

            return plainModel;
        }
    }
}
