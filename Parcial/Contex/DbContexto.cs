using Dominio;
using Microsoft.EntityFrameworkCore;


namespace Parcial.Context
{
    public class DbContexto(DbContextOptions<DbContexto> options) : DbContext(options)
    {
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Producto> Producto { get; set; }

        public DbSet<Vehiculo> Vehiculo { get; set; }
    }
}
