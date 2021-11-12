using FreeStripService.Model;
using FreeStripService.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStripService.Repositories.Abstract
{
    /// <summary>
    /// Интерфейс репозитория для Типа самолета
    /// </summary>
    public interface IPlainModelRepository
    {
        /// <summary>
        /// Метод выбирает модель самолета из базы по Id
        /// </summary>
        /// <param name="id">Id записи, которую необходимо извлечь</param>
        /// <returns>модель самолета</returns>
        PlainModel SelectById(int id);

        /// <summary>
        /// Метод выбирает все модели самолета из базы
        /// </summary>
        /// <returns>модели самолета</returns>
        ICollection<PlainModel> SelectAll();

        /// <summary>
        /// Метод добавляет новую модель самолета в базу данных
        /// </summary>
        /// <param name="plainModel">новая модель самолета</param>
        /// <returns>результат выполнения операции</returns>
        ExecutionResult Add(PlainModel plainModel);

        /// <summary>
        /// Метод изменяет модель самолета в базе данных
        /// </summary>
        /// <param name="plainModel">модель самолета, которую необходимо изменить</param>
        /// <returns>результат выполнения операции</returns>
        ExecutionResult Update(PlainModel plainModel);

        /// <summary>
        ///  Метод удаляет модель самолета в базе данных по заданному id
        /// </summary>
        /// <param name="id">id модели данных, которую необходимо удалить</param>
        /// <returns>результат выполнения операции</returns>
        ExecutionResult Delete(int id);
    }
}
