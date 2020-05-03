using System.Collections.Generic;
using FirstVa.Web.Models;

namespace FirstVa.Web.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
