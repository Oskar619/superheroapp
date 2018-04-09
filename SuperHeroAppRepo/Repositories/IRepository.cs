using System;
using System.Collections.Generic;

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