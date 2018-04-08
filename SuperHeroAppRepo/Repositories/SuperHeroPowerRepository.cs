using SuperHeroAppRepo.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroAppRepo.Repositories
{
    public class SuperHeroPowerRepository : IRepository<SuperHeroPower>, IDisposable
    {
        RepositoryContext context;

        private bool disposed = false;

        public SuperHeroPowerRepository()
        {
            context = new RepositoryContext();
        }

        public SuperHeroPowerRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public List<SuperHeroPower> GetList()
        {
            return context.Powers.ToList();
        }

        public async Task<List<SuperHeroPower>> GetListAsync()
        {
            return await context.Powers.ToListAsync();
        }

        public List<SuperHeroPower> GetFilteredList(Func<SuperHeroPower, bool> e)
        {
            return context.Powers.Where(e).ToList();
        }

        public SuperHeroPower GetById(int id)
        {
            return context.Powers.Find(id);
        }

        public void Insert(SuperHeroPower element)
        {
            context.Powers.Add(element);
        }

        public void Delete(int id)
        {
            SuperHeroPower power = context.Powers.Find(id);
            context.Powers.Remove(power);
        }

        public void Update(SuperHeroPower element)
        {
            context.Entry(element).State = EntityState.Modified;
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
