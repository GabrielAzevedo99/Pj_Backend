using Crud.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-CBCM75M; Initial Catalog=Crud;Integrated Security=true");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(table =>
            {
                table.ToTable("Clientes");
                table.HasKey(prop => prop.Id);

                table.Property(prop => prop.Lugar).HasMaxLength(40).IsRequired();
                table.Property(prop => prop.preco).HasColumnType("char(8)").IsRequired();
                table.Property(prop => prop.Tempo).HasColumnType("char(8)").IsRequired();
                table.Property(prop => prop.Situacao).HasConversion<string>().HasMaxLength(9);

            });
        }
    }
}
    

