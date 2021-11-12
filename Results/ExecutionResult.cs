using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStripService.Results
{
    /// <summary>
    /// Класс для отображения результата выполнения 
    /// </summary>
    public class ExecutionResult
    {
        /// <summary>
        /// Успешное ли выполнение
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Ошибки выявленные во время выполнения
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
