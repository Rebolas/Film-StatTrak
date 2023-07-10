using System.ComponentModel.DataAnnotations.Schema;

namespace Film_StatTrak.Models
{
    /// <summary>
    /// Dados dos filmes e series
    /// </summary>
    public class FilmesSeries
    { 
            /// <summary>
            /// PK
            /// </summary>
            public int Id { get; set; }

            /// <summary>
            /// Nome do filme
            /// </summary>
            public string Nome { get; set; }

            /// <summary>
            /// Imagem do filme
            /// </summary>
            public string Imagem { get; set; }

            /// <summary>
            /// Data do filme
            /// </summary>
            public DateTime DataFilm { get; set; }

            /// <summary>
            /// Duração do filme em minutos
            /// </summary>
            public int Duração { get; set; }
    

}
}
