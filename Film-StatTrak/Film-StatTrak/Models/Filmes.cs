namespace Film_StatTrak.Models
{
    public class Filmes : FilmesSeries
    {
        /// <summary>
        /// Sequelas do filme 
        /// </summary>
        public string Sequela { get; set; }

        /// <summary>
        /// Duração do filme em minutos
        /// </summary>
        public int Duração { get; set; }
    }
}
