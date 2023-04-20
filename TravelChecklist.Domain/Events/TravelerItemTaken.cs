using TravelChecklist.Domain.Entities;
using TravelChecklist.Domain.ValueObjects;
using TravelChecklist.Shared.Abstractions.Domain;

namespace TravelChecklist.Domain.Events
{
    public record TravelerItemTaken(TravelerCheckList TravelerCheckList, TravelerItem TravelerItem) : IDomainEvent;
}
