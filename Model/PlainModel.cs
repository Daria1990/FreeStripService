using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FreeStripService.Model
{
    /// <summary>
    /// Класс модели самолета
    /// </summary>
    public class PlainModel
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Наименование модели самолета
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Необходимая длина полосы для взлета данной модели самолета
        /// </summary>
        [Required]
        public double TakeOffStripLength { get; set; }

        /// <summary>
        /// Необходимая длина полосы для посадки данной модели самолета
        /// </summary>
        [Required]
        public double LandStripLength { get; set; }

        /// <summary>
        /// Тип самолета
        /// </summary>
        public int PlainTypeId { get; set; }

        public PlainType PlainType { get; set; }
    }
}
