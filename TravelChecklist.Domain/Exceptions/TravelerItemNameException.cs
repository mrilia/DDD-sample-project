using TravelChecklist.Shared.Abstractions.Exceptions;

namespace TravelChecklist.Domain.Exceptions
{
    public class TravelerItemNameException : TravelerCheckListException
    {

        public TravelerItemNameException() : base("Traveler item name cannot be empty.")
        {
        }
    }
}
