namespace Film_StatTrak.Models
{
    /// <summary>
    /// Dados dos filmes e séries
    /// </summary>
    public class FilmesSeries
    {
            /// <summary>
            /// PK do filme/série
            /// </summary>
            public int Id { get; set; }

            /// <summary>
            /// Nome do filme/série
            /// </summary>
            public string? Nome { get; set; }

            /// <summary>
            /// Imagem do filme/série
            /// </summary>
            public string? Imagem { get; set; }

            /// <summary>
            /// Data do filme/série
            /// </summary>
            public DateTime DataFilm { get; set; }
        }
}
