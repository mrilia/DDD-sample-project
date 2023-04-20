using TravelChecklist.Shared.Abstractions.Exceptions;

namespace TravelChecklist.Domain.Exceptions
{
    public class TravelerItemNotFoundException : TravelerCheckListException
    {
        public string ItemName { get; }

        public TravelerItemNotFoundException(string itemName) : base($"Traveler item '{itemName}' was not found.")
            => ItemName = itemName;
    }
}
