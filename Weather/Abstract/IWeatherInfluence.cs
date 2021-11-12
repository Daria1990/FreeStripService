using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStripService.Weather.Abstract
{
    /// <summary>
    /// Интерфейс для учета влияния погодных условий на работы аэропорта
    /// </summary>
    public interface IWeatherInfluence
    {
        /// <summary>
        /// Метод рассчитывает необходимую длину полосы для взлета с учетом погодных условий
        /// </summary>
        /// <param name="plainStripLength">необходимая длина полосы в идеальных условиях</param>
        /// <param name="altitudeTemp">температура в аэропорту с учетом высоты расположения над уровнем моря</param>
        /// <param name="altitude">высота расположения над уровнем моря</param>
        /// <param name="calculatedTemp">атмосферное давление</param>
        /// <returns></returns>
        double CalculateTakeOffStripLength(double plainStripLength, double altitudeTemp, double altitude, double calculatedTemp);

        /// <summary>
        /// Метод рассчитывает необходимую длину полосы для посадки с учетом погодных условий
        /// </summary>
        /// <param name="plainStripLength">необходимая длина полосы в идеальных условиях</param>
        /// <param name="calculatedPressure">атмосферное давление</param>
        /// <param name="calculatedTemp">атмосферное давление</param>
        /// <returns>длина полосы</returns>
        double CalculateLandStripLength(double plainStripLength, double calculatedPressure, double calculatedTemp);
    }
}
