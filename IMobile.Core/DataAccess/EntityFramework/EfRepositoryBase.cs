﻿using IMobile.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace IMobile.Core.DataAccess.EntityFramework
{
    public class EfRepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using var context = new TContext();
            var addEntity = context.Entry(entity);
            addEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            using var context = new TContext();
            var addRemove = context.Entry(entity);
            addRemove.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter, bool track = true)
        {
            using var context = new TContext();
            var data = context.Set<TEntity>().AsQueryable();
            if (!track)
            {
                data = context.Set<TEntity>().AsNoTracking();
            }

            return data.FirstOrDefault(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null, bool track = true)
        {
            using var context = new TContext();
            return filter == null
                   ? context.Set<TEntity>().ToList()
                   : context.Set<TEntity>().Where(filter).ToList();
        }

        public void SaveEntity()
        {
            using var context = new TContext();
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            using var context = new TContext();
            var addUpdate = context.Entry(entity);
            addUpdate.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}

