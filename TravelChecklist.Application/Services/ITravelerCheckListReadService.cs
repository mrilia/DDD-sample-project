namespace TravelChecklist.Application.Services
{
    public interface ITravelerCheckListReadService
    {
        Task<bool> ExistsByNameAsync(string name);
    }
}
