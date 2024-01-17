using Newtonsoft.Json.Linq;

string jsonText = @"{
    books: [
        {
            'title': 'Shadows of Tomorrow',
            'author': 'Elena Smith',
            'date': '2024-01-05'
        },
        {
            'title': 'Echoes of the Past',
            'author': 'Michael Johnson',
            'date': '2023-11-15'
        },
        {
            'title': 'Whispers of the Future',
            'author': 'Sarah Connor',
            'date': '2024-02-20'
        }
    ]
}";
JObject json = JObject.Parse(jsonText);

var results = from t in json["books"]
              orderby t["date"] descending
              select t["title"] + ", " + (string?)t["date"];
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
