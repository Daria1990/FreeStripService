using FreeStripService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStripService.Repositories.Abstract
{
    /// <summary>
    /// Интерфейс репозитория для Типа самолета
    /// </summary>
    public interface IPlainTypeRepository
    {
        /// <summary>
        /// Метод выбирает тип самолета из базы по Id
        /// </summary>
        /// <param name="id">Id записи, которую необходимо извлечь</param>
        /// <returns>тип самолета</returns>
        PlainType SelectById(int id);
    }
}
