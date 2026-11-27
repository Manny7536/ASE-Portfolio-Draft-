namespace StarChart
{
    /// <summary>
    /// Represents an individual star in the star catalogue.
    /// Stores the identifying information and astronomical
    /// properties of a star.
    /// </summary>
    public class Star
    {
        /// <summary>
        /// Gets or sets the unique identifier of the star.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the official or commonly recognised name of the star.
        /// </summary>
        public string? ProperName { get; set; }

        /// <summary>
        /// Gets or sets the name used to identify the star in the catalogue.
        /// </summary>
        public string CatalogueName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the right ascension coordinate of the star.
        /// </summary>
        public double RightAscension { get; set; }

        /// <summary>
        /// Gets or sets the declination coordinate of the star.
        /// </summary>
        public double Declination { get; set; }

        /// <summary>
        /// Gets or sets the distance of the star from Earth in parsecs.
        /// </summary>
        public double Distance { get; set; }

        /// <summary>
        /// Gets or sets the apparent magnitude of the star.
        /// </summary>
        public double Magnitude { get; set; }

        /// <summary>
        /// Gets or sets the absolute magnitude of the star.
        /// </summary>
        public double AbsoluteMagnitude { get; set; }

        /// <summary>
        /// Gets or sets the spectral classification of the star.
        /// </summary>
        public string? SpectralType { get; set; }

        /// <summary>
        /// Gets or sets the Cartesian X coordinate of the star.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Gets or sets the Cartesian Y coordinate of the star.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Gets or sets the Cartesian Z coordinate of the star.
        /// </summary>
        public double Z { get; set; }
    }
}
