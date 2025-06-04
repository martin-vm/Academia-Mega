using TaskManager.Models;

namespace TaskManager.Services
{
    public abstract class NotificationService : INotificationService
    {
        protected string SenderName { get; set; }
        protected NotificationService(string senderName) => SenderName = senderName;

        public abstract Task NotifyTaskCreatedAsync(TaskItem task);

    }
}