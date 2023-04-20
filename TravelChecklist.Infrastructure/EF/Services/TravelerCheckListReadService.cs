using TravelChecklist.Application.Services;
using TravelChecklist.Infrastructure.EF.Contexts;
using TravelChecklist.Infrastructure.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace TravelChecklist.Infrastructure.EF.Services
{
    internal sealed class TravelerCheckListReadService : ITravelerCheckListReadService
    {
        private readonly DbSet<TravelerCheckListReadModel> _travelerCheckList;

        public TravelerCheckListReadService(ReadDbContext context)
            => _travelerCheckList = context.TravelerCheckList;

        public Task<bool> ExistsByNameAsync(string name)
            => _travelerCheckList.AnyAsync(pl => pl.Name == name);
    }
}
