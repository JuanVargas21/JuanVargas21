using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using Anun.SHARED.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Anun.API.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Empleado> Empleados { get; set; }

        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Web> Webs { get; set; }
        public DbSet<Anuncio> Anuncios { get; set; }
       
      


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}