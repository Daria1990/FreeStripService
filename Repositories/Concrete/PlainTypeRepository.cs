using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeStripService.Model;
using FreeStripService.Data;
using FreeStripService.Repositories.Abstract;

namespace FreeStripService.Repositories.Concrete
{
    /// <summary>
    ///  Репозиторий для Типа самолета
    /// </summary>
    public class PlainTypeRepository : BaseRepository, IPlainTypeRepository
    {
        /// <summary>
        /// Конструктор класса 
        /// </summary>
        /// <param name="context">Контекст базы данных</param>
        public PlainTypeRepository(AirTransportContext context) : base(context)
        {
        }

        /// <summary>
        /// Метод выбирает тип самолета из базы по Id
        /// </summary>
        /// <param name="id">Id записи, которую необходимо извлечь</param>
        /// <returns>тип самолета</returns>
        public PlainType SelectById(int id)
        {
            var plainType = _DBContext.PlainTypes.FirstOrDefault(p => p.Id == id);

            return plainType ?? throw new ArgumentOutOfRangeException(nameof(id));
        }
    }
}
