namespace Film_StatTrak.Models
{
    /// <summary>
    /// Dados dos utilizadores
    /// </summary>
    public class Utilizadores
    {
        /// <summary>
        /// PK do utilizador
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do utilizador
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Imagem de perfil do utilizador
        /// </summary>
        public string Imagem { get; set; }

        /// <summary>
        /// E-mail do utilizador
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Duração do filme em minutos
        /// </summary>
        public int Duração { get; set; }
    }
}
