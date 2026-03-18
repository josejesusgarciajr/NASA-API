using NASA_API.Models;

namespace NASA_API.Services
{
    public class NasaService
    {
        private readonly HttpClient _httpClient;
        private const string NASA_Exoplanets_URL = "https://exoplanetarchive.ipac.caltech.edu/TAP/sync?query=select+pl_name,hostname,ra,dec,sy_dist,pl_rade+from+pscomppars+where+sy_dist+is+not+null&format=json";

        public NasaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Exoplanet[]> GetExoplanets()
        {
            var exoplanets = await _httpClient.GetFromJsonAsync<Exoplanet[]>(NASA_Exoplanets_URL);

            return exoplanets ?? [];
        }
    }
}
