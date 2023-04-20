using TravelChecklist.Shared.Abstractions.Exceptions;

namespace TravelChecklist.Domain.Exceptions
{
    public class TravelerItemAlreadyExistsException : TravelerCheckListException
    {
        public string ListName { get; }
        public string ItemName { get; }

        public TravelerItemAlreadyExistsException(string listName, string itemName)
            : base($"Traveler Check list: '{listName}' already defined item '{itemName}'")
        {
            ListName = listName;
            ItemName = itemName;
        }
    }
}
