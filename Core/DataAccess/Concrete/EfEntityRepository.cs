﻿using Core.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.Concrete
{
    public class EfEntityRepository<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter)
        {
            using TContext context = new TContext();
            return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using TContext context = new TContext();
            return context.Set<TEntity>().SingleOrDefault(filter)!;
        }

        public TEntity Add(TEntity entity)
        {
            using TContext context = new TContext();
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
            return addedEntity.Entity;
        }

        public void Update(TEntity entity)
        {
            using TContext context = new TContext();
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            using TContext context = new TContext();
            //var deletedEntity = context.Entry(entity);
           // deletedEntity.State = EntityState.Deleted;
            context.Remove(entity);
            context.SaveChanges();
        }
    }
}