
using TravelChecklist.Application.DTO;
using TravelChecklist.Infrastructure.EF.Contexts;
using TravelChecklist.Infrastructure.EF.Models;
using TravelChecklist.Infrastructure.EF.Queries;
using TravelChecklist.Shared.Abstractions.Queries;
using Microsoft.EntityFrameworkCore;

namespace TravelChecklist.Application.Queries.Handlers
{
    internal sealed class GetTravelerCheckListHandler : IQueryHandler<GetTravelerCheckList, TravelerCheckListDto>
    {
        private readonly DbSet<TravelerCheckListReadModel> _TravelerCheckLists;

        public GetTravelerCheckListHandler(ReadDbContext context)
            => _TravelerCheckLists = context.TravelerCheckList;

        public Task<TravelerCheckListDto> HandleAsync(GetTravelerCheckList query)
            => _TravelerCheckLists
                .Include(pl => pl.Items)
                .Where(pl => pl.Id == query.Id)
                .Select(pl => pl.AsDto())
                .AsNoTracking()
                .SingleOrDefaultAsync();
    }
}
