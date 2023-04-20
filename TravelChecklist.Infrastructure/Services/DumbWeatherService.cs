using TravelChecklist.Application.DTO.External;
using TravelChecklist.Application.Services;
using TravelChecklist.Domain.ValueObjects;

namespace TravelChecklist.Infrastructure.Services
{
    internal sealed class DumbWeatherService : IWeatherService
    {
        public Task<WeatherDto> GetWeatherAsync(Destination destination)
            => Task.FromResult(new WeatherDto(new Random().Next(5, 30)));
    }
}
