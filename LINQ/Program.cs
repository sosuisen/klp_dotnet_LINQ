List<Task> tasks = [
    new Task("Buy milk", DateTime.Now),
    new Task("Buy PC", new DateTime(2023, 12, 24), true),
    new Task("Buy chocolate", new DateTime(2024, 2, 14), true)
];

// query syntax
var results = from t in tasks
              orderby t.Deadline descending
              select $"{t.Name}, {t.Deadline}";
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
