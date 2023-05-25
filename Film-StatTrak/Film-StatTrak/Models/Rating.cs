using System.ComponentModel.DataAnnotations.Schema;

namespace Film_StatTrak.Models
{
    public class Ratings
    {

        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Rating
        /// </summary>
        public int Rating { get; set; }



        // ****************************************
        // Criação das chaves forasteiras
        // ****************************************

        /// <summary>
        /// FK para a identificação da Raça do animal
        /// </summary>
        [ForeignKey(nameof(Filme))]
        public int FilmeFK { get; set; }
        public FilmesSeries Filme { get; set; }
    }
}
