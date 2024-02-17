List<Task> tasks = [
    new Task("Buy milk", DateTime.Now),
    new Task("Buy PC", new DateTime(2023, 12, 24), true),
    new Task("Buy chocolate", new DateTime(2024, 2, 14), true)
];

// var results = tasks.Select(t => $"{t.Name}, {t.Deadline}");

/*
var results = tasks.Where(t => t.Deadline < new DateTime(2024, 1, 1))
    .Select(t => $"{t.Name}, {t.Deadline}");
*/

/*
   var results = tasks.Where(t => t.Name.Contains("milk"))
    .Select(t => $"{t.Name}, {t.Deadline}");
*/

var results = tasks.OrderByDescending(t => t.Deadline)
    .Select(t => $"{t.Name}, {t.Deadline}");

foreach (var item in results)
{
    Console.WriteLine(item);
}

class Task(string name, DateTime deadline, bool completed = false)
{
    public string Name { get; set; } = name;
    public DateTime Deadline { get; set; } = deadline;
    public bool Completed { get; set; } = completed;
}
