using API_Filmes_SENAI.Domains;
using API_Filmes_SENAI.NovaPasta;
using Microsoft.EntityFrameworkCore;


namespace API_Filmes_SENAI.Context
{
    public class Filmes_Context : DbContext
    {
        public Filmes_Context() 
        {
        }
        public Filmes_Context(DbContextOptions<Filmes_Context> options) : base(options) 
        {
        }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Filme> Filme { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NOTE24-S28\\SQLEXPRESS; Database=filmes_senai; User Id=sa; Pwd = Senai@134; TrustServerCertificate=true;");
            }
        }
    }
}

