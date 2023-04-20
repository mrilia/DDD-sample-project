using TravelChecklist.Domain.ValueObjects;
using TravelChecklist.Shared.Abstractions.Exceptions;

namespace TravelChecklist.Application.Exceptions
{
    public class MissingDestinationWeatherException : TravelerCheckListException
    {
        public Destination Destination { get; }

        public MissingDestinationWeatherException(Destination destination)
            : base($"Couldn't fetch weather data for Destination '{destination.Country}/{destination.City}'.")
        {
            Destination = destination;
        }
    }
}
