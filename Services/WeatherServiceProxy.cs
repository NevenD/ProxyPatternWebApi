
using System.Collections.Concurrent;

namespace ProxyPatternWebApi.Services
{
    public class WeatherServiceProxy : IWeatherService
    {

        private readonly IWeatherService _realService;
        private readonly ConcurrentDictionary<string, string> _cache = new();

        public WeatherServiceProxy(IWeatherService realService)
        {
            _realService = realService;
        }

        public async Task<string> GetWeatherAsync(string city)
        {
            if (_cache.TryGetValue(city, out var cached))
            {
                return $"[CACHE] {cached}";
            }

            var result = await _realService.GetWeatherAsync(city);
            _cache[city] = result;
            return result;
        }
    }
}
