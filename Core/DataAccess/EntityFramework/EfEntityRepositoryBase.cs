using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext>:IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //IDisposable pattern implementation of C#
            using (TContext context = new TContext()) //Using kullanmak bellekten tasarruf sağlar. Zorunlu değil
            {
                var addedEntity = context.Entry(entity); //Veri kaynağı ile ilişkilendir
                addedEntity.State = EntityState.Added;  //Veri kaynağına ekle
                context.SaveChanges(); //Save
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext()) //Using kullanmak bellekten tasarruf sağlar. Zorunlu değil
            {
                var deletedEntity = context.Entry(entity); //Veri kaynağı ile ilişkilendir
                deletedEntity.State = EntityState.Deleted;  //Veri kaynağından sil
                context.SaveChanges(); //Save
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext()) //Using kullanmak bellekten tasarruf sağlar. Zorunlu değil
            {
                var updatedEntity = context.Entry(entity); //Veri kaynağı ile ilişkilendir
                updatedEntity.State = EntityState.Modified;  //Veri kaynağını güncelle
                context.SaveChanges(); //Save
            }
        }
    }
}
