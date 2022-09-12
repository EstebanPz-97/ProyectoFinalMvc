using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class WebApplication2DbContext:DbContext
    {
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public WebApplication2DbContext(DbContextOptions<WebApplication2DbContext>options):base(options)
        {

        }

    }
}
