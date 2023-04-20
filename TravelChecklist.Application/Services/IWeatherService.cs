using TravelChecklist.Application.DTO.External;
using TravelChecklist.Domain.ValueObjects;

namespace TravelChecklist.Application.Services
{
    public interface IWeatherService
    {
        Task<WeatherDto> GetWeatherAsync(Destination localization);
    }
}
