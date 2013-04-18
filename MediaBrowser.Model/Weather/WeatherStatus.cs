﻿
namespace MediaBrowser.Model.Weather
{
    /// <summary>
    /// Represents the current weather status
    /// </summary>
    public class WeatherStatus
    {
        /// <summary>
        /// Gets or sets the temperature fahrenheit.
        /// </summary>
        /// <value>The temperature fahrenheit.</value>
        public int TemperatureFahrenheit { get; set; }

        /// <summary>
        /// Gets or sets the temperature celsius.
        /// </summary>
        /// <value>The temperature celsius.</value>
        public int TemperatureCelsius { get; set; }

        /// <summary>
        /// Gets or sets the humidity.
        /// </summary>
        /// <value>The humidity.</value>
        public int Humidity { get; set; }

        /// <summary>
        /// Gets or sets the condition.
        /// </summary>
        /// <value>The condition.</value>
        public WeatherConditions Condition { get; set; }
    }

    /// <summary>
    /// Enum WeatherConditions
    /// </summary>
    public enum WeatherConditions
    {
        /// <summary>
        /// The sunny
        /// </summary>
        Sunny,
        /// <summary>
        /// The partly cloudy
        /// </summary>
        PartlyCloudy,
        /// <summary>
        /// The cloudy
        /// </summary>
        Cloudy,
        /// <summary>
        /// The overcast
        /// </summary>
        Overcast,
        /// <summary>
        /// The mist
        /// </summary>
        Mist,
        /// <summary>
        /// The snow
        /// </summary>
        Snow,
        /// <summary>
        /// The rain
        /// </summary>
        Rain,
        /// <summary>
        /// The sleet
        /// </summary>
        Sleet,
        /// <summary>
        /// The fog
        /// </summary>
        Fog,
        /// <summary>
        /// The blizzard
        /// </summary>
        Blizzard,
        /// <summary>
        /// The thunderstorm
        /// </summary>
        Thunderstorm
    }
}
