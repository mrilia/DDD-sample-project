using TravelChecklist.Application.DTO;
using TravelChecklist.Shared.Abstractions.Queries;

namespace TravelChecklist.Application.Queries
{
    public class SearchTravelerCheckList : IQuery<IEnumerable<TravelerCheckListDto>>
    {
        public string SearchPhrase { get; set; }
    }
}
