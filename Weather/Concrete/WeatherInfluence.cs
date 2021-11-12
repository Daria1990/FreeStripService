using FreeStripService.Weather.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStripService.Weather.Concrete
{
    /// <summary>
    /// Класс для учета влияния погодных условий на работы аэропорта
    /// </summary>
    public class WeatherInfluence : IWeatherInfluence
    {
        /// <summary>
        /// Метод рассчитывает необходимую длину полосы для взлета с учетом погодных условий
        /// </summary>
        /// <param name="plainStripLength">необходимая длина полосы в идеальных условиях</param>
        /// <param name="altitudeTemp">температура в аэропорту с учетом высоты расположения над уровнем моря</param>
        /// <param name="altitude">высота расположения над уровнем моря</param>
        /// <param name="calculatedTemp">атмосферное давление</param>
        /// <returns></returns>
        public double CalculateTakeOffStripLength(double plainStripLength, double altitudeTemp, double altitude, double calculatedTemp)
        {
            var tempCorrection = 1 + WeatherConstants.CorrectionTemperatureFactor * (calculatedTemp - altitudeTemp);

            var altitudeCorrection = 1 + WeatherConstants.CorrectionAltitudeFactor * 
                                            ( altitude / WeatherConstants.SignificantPressureAltitude);

            return plainStripLength * tempCorrection * altitudeCorrection;
        }

        /// <summary>
        /// Метод рассчитывает необходимую длину полосы для посадки с учетом погодных условий
        /// </summary>
        /// <param name="plainStripLength">необходимая длина полосы в идеальных условиях</param>
        /// <param name="calculatedPressure">атмосферное давление</param>
        /// <param name="calculatedTemp">атмосферное давление</param>
        /// <returns>длина полосы</returns>
        public double CalculateLandStripLength(double plainStripLength, double calculatedPressure, double calculatedTemp)
        {
            var airDensity = WeatherConstants.CorrectionPressureFactor * 
                                    ( calculatedPressure / calculatedTemp + WeatherConstants.KelvinDegree);

            var altitudeCorrection = 1 / airDensity;

            return plainStripLength * altitudeCorrection;
        }
    }
}
