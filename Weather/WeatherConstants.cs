using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeStripService.Weather
{
    /// <summary>
    /// Класс для хранения постоянных значений у погоды
    /// </summary>
    public class WeatherConstants
    {
        /// <summary>
        /// Температура по Кельвину при 0 градусах Цельсия
        /// </summary>
        public const double KelvinDegree = 273.15;

        /// <summary>
        /// Правочный коэффициент при рассчете температуры
        /// </summary>
        public const double CorrectionTemperatureFactor = 0.01;

        /// <summary>
        /// Правочный коэффициент при рассчете высоты
        /// </summary>
        public const double CorrectionAltitudeFactor = 0.09;

        /// <summary>
        /// Количество метров от земли, где уже другое давление
        /// </summary>
        public const int SignificantPressureAltitude = 300;

        /// <summary>
        /// Правочный коэффициент при рассчете давления
        /// </summary>
        public const double CorrectionPressureFactor = 0.379;
    }
}