using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroAppRepo.Repositories
{
    interface IRepository<T> : IDisposable where T : class
    {
        List<T> GetList();
        T GetById(int id);
        void Insert(T element);
        void Delete(int id);
        void Update(T element);
        void Save();
    }
}