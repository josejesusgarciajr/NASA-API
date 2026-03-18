namespace NASA_API.Models
{
    public class Exoplanet
    {
        public string pl_name { get; set; } = string.Empty;     // planet name: ex: Kepler-1167 b
        public string hostname { get; set; } = string.Empty;    // host star name: ex: Kepler-2267
        public double ra { get; set; }                           // right ascension (degrees 0-360)
        public double dec { get; set; }                          // declination (degrees -90 to +90)
        public double sy_dist { get; set; }                      // distance from Earth in parsecs
        public double? pl_rade { get; set; }                     // planet radisu in Earth radii
    }
}
