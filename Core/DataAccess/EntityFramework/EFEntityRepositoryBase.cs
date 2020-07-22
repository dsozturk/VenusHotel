﻿using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace Core.DataAccess.EntityFramework
{
    public class EFEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
     where TEntity : class, IEntity, new()
     where TContext : DbContext, new()
    {
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var db = new TContext())
            {
                var result = db.Set<TEntity>().FirstOrDefault(filter);
                return result;
            }
        }
        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var db = new TContext())
            {
                var result = filter == null ? db.Set<TEntity>().ToList() : db.Set<TEntity>().Where(filter).ToList();
                return result;
            }
        }
        public void Add(TEntity entity)
        {
            using (var db = new TContext())
            {
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
            }
        }
        public void Update(TEntity entity)
        {
            using (var db = new TContext())
            {
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void Delete(TEntity entity)
        {
            using (var db = new TContext())
            {
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }




}
