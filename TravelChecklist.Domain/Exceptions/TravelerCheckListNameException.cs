using TravelChecklist.Shared.Abstractions.Exceptions;

namespace TravelChecklist.Domain.Exceptions
{
    public class TravelerCheckListNameException : TravelerCheckListException
    {

        public TravelerCheckListNameException() : base("Traveler CheckList list name cannot be empty.")
        {
        }
    }
}
