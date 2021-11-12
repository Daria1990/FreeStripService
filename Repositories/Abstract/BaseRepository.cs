using FreeStripService.Data;
using FreeStripService.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStripService.Repositories.Abstract
{
    /// <summary>
    /// Базовый класс репозитория
    /// </summary>
    public class BaseRepository
    {
        /// <summary>
        /// Контекст базы данных
        /// </summary>
        protected AirTransportContext _DBContext;

        /// <summary>
        /// Конструктор класса 
        /// </summary>
        /// <param name="context">Контекст базы данных</param>
        public BaseRepository(AirTransportContext context)
        {
            _DBContext = context;
        }

        /// <summary>
        /// Метод сохранения изменений в базе данных
        /// </summary>
        /// <returns></returns>
        protected ExecutionResult SaveChanges()
        {
            try
            {
                _DBContext.SaveChanges();

                return new ExecutionResult { Success = true };
            }
            catch (Exception ex)
            {
                return new ExecutionResult 
                { 
                    Success = false, 
                    ErrorMessage = ex.InnerException.Message 
                };
            }
        }
    }
}
