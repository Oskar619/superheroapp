using SuperHeroAppRepo.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroAppRepo.Repositories
{
    public class SuperHeroRepository : IRepository<SuperHero>, IDisposable
    {
        RepositoryContext context;

        private bool disposed = false;

        public SuperHeroRepository()
        {
            context = new RepositoryContext();
        }

        public SuperHeroRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public List<SuperHero> GetList()
        {
            return context.Heroes.ToList();
        }

        public async Task<List<SuperHero>> GetListAsync()
        {
            return await context.Heroes.ToListAsync();
        }

        public SuperHero GetById(int id)
        {
            return context.Heroes.Find(id);
        }

        public SuperHero GetByAssemblyName(string assemblyName)
        {
            return context.Heroes.FirstOrDefault(x => x.AssemblyName == assemblyName);
        }

        public async Task<SuperHero> GetByAssemblyNameAsync(string assemblyName)
        {
            return await context.Heroes.FirstOrDefaultAsync(x => x.AssemblyName == assemblyName);
        }

        public void Insert(SuperHero element)
        {
            context.Heroes.Add(element);
        }

        public void Delete(int id)
        {
            SuperHero hero = context.Heroes.Find(id);
            context.Heroes.Remove(hero);
        }

        public void Update(SuperHero element)
        {
            context.Entry(element).State = EntityState.Modified;
        }

        public void ResetPowers(SuperHero element)
        {
            var pws = context.Powers.Where(x => x.SuperHeroId == element.Id);
            context.Powers.RemoveRange(pws);
            context.SaveChanges();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
