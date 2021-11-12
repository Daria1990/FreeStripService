using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeStripService.Model;
using FreeStripService.Data;
using Microsoft.EntityFrameworkCore;
using FreeStripService.Results;
using FreeStripService.Repositories.Abstract;

namespace FreeStripService.Repositories.Concrete
{
    /// <summary>
    /// Репозиторий для Модели самолета
    /// </summary>
    public class PlainModelRepository : BaseRepository, IPlainModelRepository
    {
        /// <summary>
        /// Конструктор класса 
        /// </summary>
        /// <param name="context">Контекст базы данных</param>
        public PlainModelRepository(AirTransportContext context) : base(context)
        {
        }

        /// <summary>
        /// Метод выбирает модель самолета из базы по Id
        /// </summary>
        /// <param name="id">Id записи, которую необходимо извлечь</param>
        /// <returns>модель самолета</returns>
        public PlainModel SelectById(int id)
        {
            var plainModel = _DBContext.PlainModels.Include(p => p.PlainType).FirstOrDefault(p => p.Id == id);

            return plainModel ?? throw new ArgumentOutOfRangeException(nameof(id));
        }

        /// <summary>
        /// Метод выбирает все модели самолета из базы
        /// </summary>
        /// <returns>модели самолета</returns>
        public ICollection<PlainModel> SelectAll()
        {
            return _DBContext.PlainModels.ToList();
        }

        /// <summary>
        /// Метод добавляет новую модель самолета в базу данных
        /// </summary>
        /// <param name="plainModel">новая модель самолета</param>
        /// <returns>результат выполнения операции</returns>
        public ExecutionResult Add(PlainModel plainModel)
        {
            if(plainModel == null)
            {
                throw new ArgumentNullException(nameof(plainModel));
            }

            _DBContext.PlainModels.Add(plainModel);

            return SaveChanges();
        }

        /// <summary>
        /// Метод изменяет модель самолета в базе данных
        /// </summary>
        /// <param name="plainModel">модель самолета, которую необходимо изменить</param>
        /// <returns>результат выполнения операции</returns>
        public ExecutionResult Update(PlainModel plainModel)
        {
            if (plainModel == null)
            {
                throw new ArgumentNullException(nameof(plainModel));
            }

            _DBContext.PlainModels.Update(plainModel);

            return SaveChanges();
        }

        /// <summary>
        ///  Метод удаляет модель самолета в базе данных по заданному id
        /// </summary>
        /// <param name="id">id модели данных, которую необходимо удалить</param>
        /// <returns>результат выполнения операции</returns>
        public ExecutionResult Delete(int id)
        {
            var plainModel = SelectById(id);

            _DBContext.PlainModels.Remove(plainModel);

            return SaveChanges();
        }
    }
}
