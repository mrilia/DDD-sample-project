using TravelChecklist.Application.DTO;
using TravelChecklist.Shared.Abstractions.Queries;

namespace TravelChecklist.Application.Queries
{
    public class GetTravelerCheckList : IQuery<TravelerCheckListDto>
    {
        public Guid Id { get; set; }
    }
}
