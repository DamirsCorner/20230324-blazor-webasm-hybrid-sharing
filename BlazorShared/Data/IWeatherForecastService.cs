namespace BlazorShared.Data;

public interface IWeatherForecastService
{
    Task<WeatherForecast[]?> GetForecastAsync(DateTime startDate);
}