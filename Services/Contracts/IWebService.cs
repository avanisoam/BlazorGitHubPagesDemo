using Kathboli.Shared.Dtos;

namespace BlazorGitHubPagesDemo.Services.Contracts
{
    public interface IWebService
    {
        Task<IEnumerable<WeatherForecastDto>> GetWeatherForecast();
    }
}
