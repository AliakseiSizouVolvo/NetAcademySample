using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonSerializationAndAttributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var weatherForecast = new WeatherForecast()
            {
                Date = DateTime.Now.AddDays(1),
                Temperature = 295,
                TemperatureUnit = TemperatureUnit.Kelvin,
                Summary = "all good!",
                ResponsibleMeteorologist = "Michael Thompson",
                WindSpeedMPerS = 10
            };

            var serialized = JsonSerializer.Serialize(weatherForecast);
            Console.WriteLine(serialized);
            Console.WriteLine();

            serialized = JsonSerializer.Serialize(
                weatherForecast,
                new JsonSerializerOptions()
                {
                    WriteIndented = true,
                    PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseUpper
                });

            Console.WriteLine(serialized);
            Console.WriteLine();

            var opts = new JsonSerializerOptions()
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            opts.Converters.Add(new JsonStringEnumConverter());

            serialized = JsonSerializer.Serialize(weatherForecast, opts);
            Console.WriteLine(serialized);
            Console.WriteLine();

            var windSpped = 30;
            var deserialized = JsonSerializer.Deserialize<WeatherForecast>($$"""
                 {
                  "date": "2023-12-20T20:11:23.295088+01:00",
                  "temperature": 25,
                  "temperatureUnit": "Celsius",
                  "summary": "bit chilly!",
                  "responsibleMeteorologist": "Ron Allan",
                  "Wind": {{windSpped}}
                 }
                 """, opts);
        }
    }

    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int Temperature { get; set; }
        public TemperatureUnit TemperatureUnit { get; set; } 
        public string? Summary { get; set; }
        [JsonConverter(typeof(JsonAnonymizeConverterInner))]
        public string? ResponsibleMeteorologist { get; set; }
        [JsonPropertyName("Wind")]
        public int WindSpeedMPerS { get; set; }
    }

    public enum  TemperatureUnit
    {
        Celsius, Fahrenheit, Kelvin
    }
}
