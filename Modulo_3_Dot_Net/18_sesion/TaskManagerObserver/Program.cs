using Domain;
using Infraestructure;
using Subscribers;

var bus = new EventBus();
var repo = new TaskRepository(bus);

bus.Subscribe(new EmailNotifier());
bus.Subscribe(new SmsNotifier());
bus.Subscribe(new ConsoleUI());

//LA PRUEBA

var task1 = repo.Add(new TaskItem { Title = "Aprender Patron Observer" });
var task2 = repo.Add(new TaskItem { Title = "Conectar PubSub a todo el proyecto" });


task1.Complete();
Console.WriteLine(task1.IsDone);

repo.Delete(task2.id);