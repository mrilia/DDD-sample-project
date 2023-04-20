using TravelChecklist.Domain.ValueObjects;

namespace TravelChecklist.Domain.Policies
{
    public record PolicyData(TravelDays Days, Consts.Gender Gender, ValueObjects.Temperature Temperature,
        Destination Destination);
}
