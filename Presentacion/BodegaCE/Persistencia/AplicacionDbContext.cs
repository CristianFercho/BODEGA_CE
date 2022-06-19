namespace Persistencia
{
    using DominioTO;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    public class AplicacionDbContext : IdentityDbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MovimientoEntrada>().HasKey(ci => new { ci.BodegaId, ci.ProductoId });
        }

        public DbSet<Bodega> bodega { get; set; }
        public DbSet<Producto> producto { get; set; }
        public DbSet<MovimientoEntrada> movimientoEntrada { get; set; }
        public DbSet<Proveedor> proveedor { get; set; }
        public DbSet<Cliente> cliente { get; set; }
    }
}
