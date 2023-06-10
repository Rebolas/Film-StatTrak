using Film_StatTrak.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Film_StatTrak.Data {
    /// <summary>
    /// base de dados do nosso projeto
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {

        }
        // ********************************************
        // Criação das tabelas da BD
        // ********************************************
        public DbSet<FilmesSeries> FilmesSeries { get; set; }
    }
}