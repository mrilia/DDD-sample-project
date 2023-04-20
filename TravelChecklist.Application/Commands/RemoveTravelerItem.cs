using TravelChecklist.Shared.Abstractions.Commands;

namespace TravelChecklist.Application.Commands
{
    public record RemoveTravelerItem(Guid TravelerCheckListId, string Name) : ICommand;
}
