using TaskManager.Shared.Domain;

namespace TaskManager.Repositories
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskItem>> GetAllAsync();
        Task AddAsync(TaskItem taskItem);
        Task<TaskItem?> GetAsync(Guid id);
        Task UpdateAsync(TaskItem taskItem);
        Task DeleteAsync(Guid id);
    }
}