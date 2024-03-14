using Microsoft.EntityFrameworkCore;
using Shared.Models;
namespace TicketsApp.Api.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> Options) : base(Options) { }
        public DbSet<Prioridades> Prioridades { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Tickets_Detalle> Tickets_Detalle { get; set; }
        public DbSet<Sistemas> Sistemas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Sistemas>().HasData(new List<Sistemas>()
            {
                new Sistemas() {SistemaId = 1, Nombre="FacturacionBodega"},
                new Sistemas() { SistemaId = 2,Nombre="ComputoProductos"},
                new Sistemas() { SistemaId=3, Nombre="SAGSystem"}
            }) ;
        }

    }
}
