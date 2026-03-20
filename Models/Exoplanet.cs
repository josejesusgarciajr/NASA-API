namespace NASA_API.Models
{
    public class Exoplanet
    {
        // Identity
        public string pl_name { get; set; } = string.Empty;
        public string hostname { get; set; } = string.Empty;

        // Position
        public double ra { get; set; }
        public double dec { get; set; }
        public double sy_dist { get; set; }

        // Planet parameters
        public double? pl_rade { get; set; }       // planet radius (Earth radii)
        public double? pl_masse { get; set; }      // planet mass (Earth masses)
        public double? pl_orbper { get; set; }     // orbital period (days)
        public double? pl_orbsmax { get; set; }   // semi-major axis (AU)
        public double? pl_orbeccen { get; set; }   // orbital eccentricity
        public double? pl_eqt { get; set; }        // equilibrium temperature (K)

        // Stellar parameters
        public double? st_teff { get; set; }       // stellar temperature (K) → drives star color
        public double? st_rad { get; set; }        // stellar radius (solar radii) → drives star size
        public double? st_mass { get; set; }       // stellar mass (solar masses)
        public double? st_lum { get; set; }        // stellar luminosity (log solar)
        public string? st_spectype { get; set; }   // spectral type (G2V, K5, M3, etc.)

        // System info
        public int? sy_snum { get; set; }          // number of stars in system
        public int? sy_pnum { get; set; }          // number of planets in system

        // Discovery
        public string? discoverymethod { get; set; }
        public int? disc_year { get; set; }
    }
}
