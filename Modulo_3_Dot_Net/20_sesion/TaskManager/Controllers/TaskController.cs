using Microsoft.AspNetCore.Mvc;
using TaskManager.Shared.Domain;
using TaskManager.Repositories;
using TaskManager.Services;

namespace TaskManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository _repo;
        private readonly IEnumerable<INotificationService> _notifiers;

        public TaskController(ITaskRepository repo, IEnumerable<INotificationService> notifiers)
        {
            _repo = repo;
            _notifiers = notifiers;
        }

        [HttpGet] //GET /api/task
        public async Task<IEnumerable<TaskItem?>> GetAll() =>
            await _repo.GetAllAsync();

        [HttpPost]
        public async Task<ActionResult<TaskItem>> Create(TaskItem taskItem)
        {
            await _repo.AddAsync(taskItem);

            foreach (var notifier in _notifiers)
                await notifier.NotifyTaskCreatedAsync(taskItem);

            return CreatedAtAction(nameof(GetAll), new { id = taskItem.id }, taskItem);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, TaskItem taskItem)
        {
            var resultado = _repo.UpdateAsync(taskItem);
            return Ok(taskItem);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var resultado = _repo.DeleteAsync(id);
            return Ok(id);
        }

    }
}