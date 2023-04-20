using TravelChecklist.Shared.Abstractions.Exceptions;

namespace TravelChecklist.Domain.Exceptions
{
    public class TravelerCheckListIdException : TravelerCheckListException
    {

        public TravelerCheckListIdException() : base("Traveler Checklist ID cannot be empty.")
        {
        }
    }
}
