using Microsoft.EntityFrameworkCore;
using WSA.Entity.Configurations;
using WSA.Model;

namespace WSA.Entity
{
    public class WSAContext : DbContext
    {
        public DbSet<Associado> Associados { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=NOTESILVA\\MSEXPRESS;Database=WSA;user id=sistema;password=123456;Trusted_connection=false;");
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WSA;Trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AssociadoConfiguration());
            modelBuilder.ApplyConfiguration(new EstadoConfiguration());
            modelBuilder.ApplyConfiguration(new CidadeConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
