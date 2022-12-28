using BlazorGitHubPagesDemo.Services.Contracts;
using Kathboli.Shared.Dtos;
using System.Net.Http.Json;

namespace BlazorGitHubPagesDemo.Services
{
    public class WebService : IWebService
    {
        private readonly HttpClient _httpClient;

        public WebService(HttpClient httpClient)
        {
            _httpClient = httpClient; 
        }
        public async Task<IEnumerable<WeatherForecastDto>> GetWeatherForecast()
        {
            try
            {
                //var response = await _httpClient.GetFromJsonAsync<IEnumerable<WeatherForecastDto>>("http://localhost:5000/WeatherForecast");
                var response = await _httpClient.GetFromJsonAsync<IEnumerable<WeatherForecastDto>>("https://www.kathboli.com/WeatherForecast");
                return response;
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}
