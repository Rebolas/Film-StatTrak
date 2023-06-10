using System.ComponentModel.DataAnnotations.Schema;

namespace Film_StatTrak.Models
{
    public class Episodios
    {
        /// <summary>
        /// PK do Episódio
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Sequelas do filme 
        /// </summary>
        public string? Nome { get; set; }

        /// <summary>
        /// Duração do episódio em minutos
        /// </summary>
        public int Duração { get; set; }

        /// <summary>
        /// Imagem do Episódio
        /// </summary>
        public string? Imagem { get; set; }

        // ****************************************
        // Criação das chaves forasteiras
        // ****************************************

        /// <summary>
        /// FK para a identificação da Série
        /// </summary>
        [ForeignKey(nameof(FilmesSeries))]
        public int FilmesSeriesFK { get; set; }
        public FilmesSeries FilmeSerie { get; set; }
    }
}
