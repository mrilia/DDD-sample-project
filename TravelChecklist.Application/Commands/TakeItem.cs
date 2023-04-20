using TravelChecklist.Shared.Abstractions.Commands;

namespace TravelChecklist.Application.Commands
{
    public record TakeItem(Guid TravelerCheckListId, string Name) : ICommand;
}
