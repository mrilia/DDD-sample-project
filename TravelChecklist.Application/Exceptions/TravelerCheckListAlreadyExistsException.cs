using TravelChecklist.Shared.Abstractions.Exceptions;

namespace TravelChecklist.Application.Exceptions
{
    public class TravelerCheckListAlreadyExistsException : TravelerCheckListException
    {
        public string Name { get; }

        public TravelerCheckListAlreadyExistsException(string name)
            : base($"Traveler Check List with name '{name}' already exists.")
        {
            Name = name;
        }
    }
}
