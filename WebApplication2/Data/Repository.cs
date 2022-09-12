using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class Repository : IRepository
    {
        private readonly WebApplication2DbContext context;
        public Repository(WebApplication2DbContext context)
        {
            this.context = context;
        }

        public async Task Commit()
        {
            await context.SaveChangesAsync();
        }

        public void Delete<T>(T obj) where T : Entity
        {
            context.Set<T>().Remove(obj);
        }
        public async Task<T> GetEquipoById<T>(Guid id) where T : Entity
        {
            return await context.Set<T>().FindAsync(id);  
        }
        public async Task<List<T>> GetAll<T>() where T : Entity
        {
            return await context.Set<T>().ToListAsync(); 
        }

        public async Task Save<T>(T obj) where T : Entity
        {
            await context.Set<T>().AddAsync(obj);
        }

        public void Update<T>(T obj) where T : Entity
        {
            context.Update(obj);
        }
    }
}
