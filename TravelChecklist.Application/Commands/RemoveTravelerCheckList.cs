using TravelChecklist.Shared.Abstractions.Commands;

namespace TravelChecklist.Application.Commands
{
    public record RemoveTravelerCheckList(Guid Id) : ICommand;
}

