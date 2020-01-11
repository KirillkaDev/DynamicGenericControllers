using System;
using GenericControllersExample.Attributes;

namespace GenericControllersExample.Models
{
    [GeneratedController("api/pen")]
    public class Pen
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public int Length { get; set; }
    }

    [GeneratedController("api/song")]
    public class Song
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Artist { get; set; }
    }

    [GeneratedController("api/user")]
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
