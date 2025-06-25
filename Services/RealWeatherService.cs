
namespace ProxyPatternWebApi.Services
{
    public class RealWeatherService : IWeatherService
    {
        public async Task<string> GetWeatherAsync(string city)
        {
            await Task.Delay(1000);

            return $"Weather in {city}: Sunny, 25°C (fetched from real service)";
        }
    }
}
