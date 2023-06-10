namespace Film_StatTrak.Models
{
    /// <summary>
    /// Dados das séries
    /// </summary>
    public class Series : FilmesSeries
    {
        /// <summary>
        /// Temporadas da série 
        /// </summary>
        public string Temporada { get; set; }

        public List<Episodios> Eps { get; set; } = new();
    }
}
