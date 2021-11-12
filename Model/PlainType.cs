using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FreeStripService.Model
{
    /// <summary>
    /// Тип самолета
    /// </summary>
    public class PlainType
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Наименование типа самолета
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Количество минут необходимых для подготовки к взлету
        /// </summary>
        [Required]
        public int PickUpMinutes { get; set; }

        /// <summary>
        /// Количество минут на взлетной полосе необходимых для посадки и сразу после нее
        /// </summary>
        [Required]
        public int PickOffMinutes { get; set; }

        /// <summary>
        /// Модели самолета данного типа
        /// </summary>
        public ICollection<PlainModel> PlainModels { get; set; }

        public PlainType()
        {
            PlainModels = new List<PlainModel>();
        }
    }
}
