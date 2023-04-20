using TravelChecklist.Shared.Abstractions.Commands;


namespace TravelChecklist.Application.Commands
{
    public record AddTravelerItem(Guid TravelerCheckListId, string Name, uint Quantity) : ICommand;
}
