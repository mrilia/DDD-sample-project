using TravelChecklist.Domain.Consts;
using TravelChecklist.Domain.Entities;
using TravelChecklist.Domain.Policies;
using TravelChecklist.Domain.ValueObjects;

namespace TravelChecklist.Domain.Factories
{
    public sealed class TravelerCheckListFactory : ITravelerCheckListFactory
    {

        private readonly IEnumerable<ITravelerItemsPolicy> _policies;


        public TravelerCheckListFactory(IEnumerable<ITravelerItemsPolicy> policies)
            => _policies = policies;

        public TravelerCheckList Create(TravelerCheckListId id, TravelerCheckListName name, Destination destination)
            => new(id, name, destination);

        public TravelerCheckList CreateWithDefaultItems(TravelerCheckListId id, TravelerCheckListName name, TravelDays days, Gender gender,
            Temperature temperature, Destination destination)
        {
            var data = new PolicyData(days, gender, temperature, destination);
            var applicablePolicies = _policies.Where(p => p.IsApplicable(data));

            var items = applicablePolicies.SelectMany(p => p.GenerateItems(data));
            var travelerCheckingList = Create(id, name, destination);

            travelerCheckingList.AddItems(items);

            return travelerCheckingList;
        }

    }
}
