using TravelChecklist.Domain.Consts;
using TravelChecklist.Shared.Abstractions.Commands;

namespace TravelChecklist.Application.Commands
{
    public record CreateTravelerCheckListWithItems(Guid Id, string Name, ushort Days, Gender Gender,
       DestinationWriteModel Destionation) : ICommand;

    public record DestinationWriteModel(string City, string Country);
}

