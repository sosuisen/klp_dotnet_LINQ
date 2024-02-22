using Newtonsoft.Json.Linq;

string jsonText = @"{
    'books': [
        {
            'title': 'Shadows of Tomorrow',
            'author': 'Elena Smith',
            'date': '2024-01-05'
        },
        {
            'title': 'Echoes of the Past',
            'author': 'Sarah Connor',
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

var results = json["books"].OrderByDescending(book => book["date"])
                           .Select(book => book["title"] + ", " + book["date"]);

foreach (var item in results)
{
    Console.WriteLine(item);
}
