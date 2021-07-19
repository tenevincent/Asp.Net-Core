using BlazorGrpc;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebAssembly.WithgRPC.Server.Services
{
    public class WeatherForecastsService : WeatherForecasts.WeatherForecastsBase
    {
        private static readonly string[] Summaries = new[]
      {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public override Task<WeatherReply> GetWeather(Empty request, ServerCallContext context)
        {
            var reply = new WeatherReply();

            var rng = new Random();
            var temperatureC = rng.Next(-20, 55);
            reply.Forecasts.Add(Enumerable.Range(1, 500).Select(index => new WeatherForecast
            {
                Index = index,
                DateTimeStamp = Timestamp.FromDateTime(DateTime.UtcNow.AddDays(index)),
                TemperatureC = temperatureC,
                TemperatureF = 32 + (int)(temperatureC / 0.5556),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })); 

            return Task.FromResult(reply);
        }
    }
}
