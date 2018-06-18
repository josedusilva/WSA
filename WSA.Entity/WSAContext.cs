using Microsoft.EntityFrameworkCore;
using WSA.Model;

namespace WSA.Entity
{
    public class WSAContext : DbContext
    {
        public DbSet<Associado> Associados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Associado>()
                .Property(a => a.Id)
                .HasColumnName("cdAssociado");

            modelBuilder
                .Entity<Associado>()
                .Property(a => a.Nome)
                .HasColumnName("dsNome")
                .HasColumnType("varchar(45)")
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
