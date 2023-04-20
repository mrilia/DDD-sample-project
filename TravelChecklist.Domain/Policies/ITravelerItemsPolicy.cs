using TravelChecklist.Domain.ValueObjects;

namespace TravelChecklist.Domain.Policies
{
    public interface ITravelerItemsPolicy
    {
        bool IsApplicable(PolicyData data);
        IEnumerable<TravelerItem> GenerateItems(PolicyData data);

    }
}
