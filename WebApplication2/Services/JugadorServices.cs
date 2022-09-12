using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class JugadorServices
    {
        private readonly IRepository repository;

        public JugadorServices(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task Crear(Jugador jugador)
        {
            await this.repository.Save(jugador);
            await this.repository.Commit();
        }
    }
}
