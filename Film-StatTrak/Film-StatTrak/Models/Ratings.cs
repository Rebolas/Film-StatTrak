using System.ComponentModel.DataAnnotations.Schema;

namespace Film_StatTrak.Models
{
    /// <summary>
    /// Dados dos ratings
    /// </summary>
    public class Ratings
    {
        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Valor do Rating
        /// </summary>
        public int Rating { get; set; }



        // ****************************************
        // Criação das chaves forasteiras
        // ****************************************

        /// <summary>
        /// FK para a identificação do Filme
        /// </summary>
        [ForeignKey(nameof(FilmesSeries))]
        public int FilmesSeriesFK { get; set; }
        public FilmesSeries FilmeSerie { get; set; }

        /// <summary>
        /// FK para a identificação da Série
        /// </summary>
        [ForeignKey(nameof(Utilizadores))]
        public int UtilizadoresFK { get; set; }
        public Utilizadores Utilizador { get; set; }
    }
}
