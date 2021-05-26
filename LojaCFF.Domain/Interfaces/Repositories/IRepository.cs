using LojaCFF.Domain.Entities;
using System;
using System.Collections.Generic;

namespace LojaCFF.Domain.Interfaces.Repositories
{
    public interface IRepository<T> : IDisposable where T : Entity
    {
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        IEnumerable<T> Get();
        T Get(int id);
    }
}
