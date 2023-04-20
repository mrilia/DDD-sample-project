using TravelChecklist.Shared.Abstractions.Exceptions;

namespace TravelChecklist.Domain.Exceptions
{
    internal class InvalidTravelDaysException : TravelerCheckListException
    {
        public ushort Days { get; }

        public InvalidTravelDaysException(ushort days) : base($"Value '{days}' is invalid travel days.")
            => Days = days;
    }
}
