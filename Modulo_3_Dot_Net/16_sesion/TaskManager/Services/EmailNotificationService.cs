using System.Diagnostics;
using TaskManager.Models;

namespace TaskManager.Services
{
    public class EmailNotificationService : NotificationService
    {
        public EmailNotificationService() : base("Gestor de tareas") { }

        public override Task NotifyTaskCreatedAsync(TaskItem task)
        {
            //Aquí se debe mandar el correo.
            Console.WriteLine($"[EMAIL] {SenderName}: Nueva tarea '{task.Title}'");
            return Task.CompletedTask;
        }
    }
}