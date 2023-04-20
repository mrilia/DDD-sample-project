using TravelChecklist.Application.DTO;
using TravelChecklist.Application.Queries;
using TravelChecklist.Infrastructure.EF.Contexts;
using TravelChecklist.Infrastructure.EF.Models;
using TravelChecklist.Shared.Abstractions.Queries;
using Microsoft.EntityFrameworkCore;

namespace TravelChecklist.Infrastructure.EF.Queries.Handlers
{
    internal sealed class SearchTravelerCheckListHandler : IQueryHandler<SearchTravelerCheckList, IEnumerable<TravelerCheckListDto>>
    {
        private readonly DbSet<TravelerCheckListReadModel> _TravelerCheckLists;

        public SearchTravelerCheckListHandler(ReadDbContext context)
            => _TravelerCheckLists = context.TravelerCheckList;

        public async Task<IEnumerable<TravelerCheckListDto>> HandleAsync(SearchTravelerCheckList query)
        {
            var dbQuery = _TravelerCheckLists
                .Include(pl => pl.Items)
            .AsQueryable();

            if (query.SearchPhrase is not null)
            {
                dbQuery = dbQuery.Where(pl =>
                    Microsoft.EntityFrameworkCore.EF.Functions.Like(pl.Name, $"%{query.SearchPhrase}%"));
            }

            return await dbQuery
                .Select(pl => pl.AsDto())
                .AsNoTracking()
                .ToListAsync();
        }
    }
}

