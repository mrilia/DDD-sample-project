using TravelChecklist.Domain.Consts;
using TravelChecklist.Domain.Entities;
using TravelChecklist.Domain.ValueObjects;

namespace TravelChecklist.Domain.Factories
{
    public interface ITravelerCheckListFactory
    {
        TravelerCheckList Create(TravelerCheckListId id, TravelerCheckListName name, Destination destination);

        TravelerCheckList CreateWithDefaultItems(TravelerCheckListId id, TravelerCheckListName name, TravelDays days, Gender gender,
            Temperature temperature, Destination destination);
    }
}
