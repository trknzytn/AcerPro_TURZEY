﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AcerPro.DAL.Abstracts.Repository
{
    public interface IEntityRepository<T> where T : class
    {
        void Add(T entity);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        T GetById(int id);
        void Remove(T entity);
        IEnumerable<T> GetAll();
        void Update(T entitiy, int id);
    }
}
