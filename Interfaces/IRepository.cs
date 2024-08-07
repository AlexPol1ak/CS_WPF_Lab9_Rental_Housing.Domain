﻿using System.Linq.Expressions;

namespace CS_WPF_Lab9_Rental_Housing.Domain.Interfaces
{
    /// <summary>
    /// CRUD interface of operations with models.
    /// </summary>
    /// <typeparam name="TEntity">Database entity class</typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        TEntity Get(int id, params string[] includes);
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void Create(TEntity entity);
        void Update(TEntity entity);
        bool Delete(int id);
        bool Contains(TEntity entity);
        int Count();
    }
}
