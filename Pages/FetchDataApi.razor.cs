using BlazorGitHubPagesDemo.Services.Contracts;
using Kathboli.Shared.Dtos;
using Microsoft.AspNetCore.Components;

namespace BlazorGitHubPagesDemo.Pages
{
    public partial class FetchDataApi
    {
        [Inject]
        public IWebService WebService { get; set; }

        public IEnumerable<WeatherForecastDto> Weathers { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Weathers = await WebService.GetWeatherForecast();
        }
    }
}
