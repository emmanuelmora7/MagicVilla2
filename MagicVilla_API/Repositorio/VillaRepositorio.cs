using MagicVilla_API.Datos;
using MagicVilla_API.Modelos;
using MagicVilla_API.Repositorio.IRepositorio;

namespace MagicVilla_API.Repositorio
{
    public class VillaRepositorio : Repositorio<Villa>, IVillaRepositorio
    {
        private readonly ApplicationDbContext _contex;
        public VillaRepositorio(ApplicationDbContext contex) :base(contex) 
        {
            _contex = contex;
        }
        public async Task<Villa> Actualizar(Villa entidad)
        {
            entidad.FechaActualizacion = DateTime.Now;
            _contex.Villas.Update(entidad);
            await _contex.SaveChangesAsync(); 
            return entidad;
        }
    }
}
