using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Nombre = "Emmanuel",
                    Detalle= "Detalle de la Villa",
                    ImagenUrl= "",
                    ocupantes = 3,
                    metrosCuadrados = 40,
                    Tarifa = 100,
                    Amenidad = "",
                    FechaActualizacion = DateTime.Now,
                    FechaCreacion = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Nombre = "Dana",
                    Detalle = "Detalle de la Villa11",
                    ImagenUrl = "",
                    ocupantes = 4,
                    metrosCuadrados = 50,
                    Tarifa = 150,
                    Amenidad = "",
                    FechaActualizacion = DateTime.Now,
                    FechaCreacion = DateTime.Now
                }
            );
        }
    }
}
