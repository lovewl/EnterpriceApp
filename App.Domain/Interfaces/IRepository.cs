﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable
    {
        void Add(TEntity obj);
        TEntity GetById(Guid id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(Guid id);
        int SaveChanges();
    }
}