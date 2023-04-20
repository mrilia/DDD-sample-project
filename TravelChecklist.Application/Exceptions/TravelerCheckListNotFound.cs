using TravelChecklist.Shared.Abstractions.Exceptions;

namespace TravelChecklist.Application.Exceptions
{
    public class TravelerCheckListNotFound : TravelerCheckListException
    {
        public Guid Id { get; }

        public TravelerCheckListNotFound(Guid id) : base($"Traveler CheckList list with ID '{id}' was not found.")
            => Id = id;
    }
}
