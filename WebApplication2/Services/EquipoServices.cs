
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class EquipoServices
    {

        private readonly IRepository repository;
        public EquipoServices(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task Crear(Equipo equipo)
        {
            if (equipo is null)
                throw new Exception("Equipo es nulo");

            await this.repository.Save(equipo);
            await this.repository.Commit();
        }
        public async Task<List<Equipo>> getAllEquipo()
        {
            return await this.repository.GetAll<Equipo>();
        }
        public async Task<Equipo> getEquipoById(Guid id)
        {
            return await this.repository.GetEquipoById<Equipo>(id);
        }
        public async Task Editar(Equipo equipo)
        {
            this.repository.Update(equipo);
            await this.repository.Commit();
        }
        public async Task Eliminar(Equipo equipo)
        {
            this.repository.Delete(equipo);
            await this.repository.Commit();
        }


    }

}
