﻿using AdminPanel.DataAccessLayer.Abstract.Other.EntityFramework;
using AdminPanel.EntityLayer.Abctract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AdminPanel.DataAccessLayer.Concrete.EntityFramework.Base
{
    public class EntityEfDal<TEntity, TContext> : IEntityEfDalBase<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {

        public async Task<bool> AddAsync(TEntity entity, DateTime? kayitZamani = null)
        {
            bool result = false;
            using (TContext context = new TContext())
            {

                if (entity.isNotNull() && entity.isIdEmpty())//entity.isNull() normalde ekleme nesnesinde Id olmaz lakin oracle için gerekli 
                {
                    //entity.kayitZamani = kayitZamani != null ? (DateTime)kayitZamani : DateTime.Now;
                    context.Entry(entity).State = EntityState.Added;
                    int response = await context.SaveChangesAsync();

                    if (response > 0)
                        result = true;
                }
            }
            return result;
        }

        public async Task<bool> DeleteAsync(TEntity entity, DateTime? silmeZamani = null)
        {
            bool result = false;
            using (TContext context = new TContext())
            {
                if (entity.isIdNotEmpty() & !entity.silinmisMi())
                {
                    //entity.silmeZamani = silmeZamani != null ? (DateTime)silmeZamani : DateTime.Now;

                    //// silme işlemi sanal olacak on göre ayarlama yapılacak
                    ////context.Entry(entity).State = EntityState.Deleted;
                    //entity.sil = true;
                    //context.Entry(entity).State = EntityState.Modified;
                    //int response = await context.SaveChangesAsync();

                    //if (response > 0)
                    //    result = true;
                }
            }
            return result;
        }

        public async Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>>? filter = null)
        {
            List<TEntity> result;
            using (TContext context = new TContext())
            {
               // result = context.Set<TEntity>().ToList();
                result = filter == null ? await context.Set<TEntity>().ToListAsync()
                    : await context.Set<TEntity>().Where(filter).ToListAsync();
            }
            return result;
        }

        //public async Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter)
        //{
        //    List<TEntity> result;
        //    using (TContext context = new TContext())
        //    {
        //        result = await context.Set<TEntity>().Where(filter).ToListAsync();
        //    }
        //    return result;
        //}

        public async Task<bool> UpdateAsync(TEntity entity, DateTime? guncellemeZamani = null)
        {
            bool result = false;
            using (TContext context = new TContext())
            {
                if (entity.isIdNotEmpty())
                {
                    //entity.guncellemeZamani = guncellemeZamani != null ? (DateTime)guncellemeZamani : DateTime.Now;

                    context.Entry(entity).State = EntityState.Modified;
                    int response = await context.SaveChangesAsync();

                    if (response > 0)
                        result = true;
                }
            }
            return result;
        }

        public async Task<int> GetTotalCountAsync(Expression<Func<TEntity, bool>>? filter = null)
        {
            int response = 0;
            using (TContext context = new TContext())
            {
                response = filter == null ? await context.Set<TEntity>().CountAsync()
                    : await context.Set<TEntity>().Where(filter).CountAsync();
            }
            return response;
        }


        public async Task<List<TEntity>> GetPaginationAsync(int pageItemsCount, int pageIndex, Expression<Func<TEntity, bool>>? filter = null)
        {
            List<TEntity> response = null;

            int totalItems = await GetTotalCountAsync(filter);

            int mod = totalItems % pageItemsCount;
            int pageCount = mod == 0 ? totalItems / pageItemsCount : ((totalItems - mod) / pageItemsCount) + 1;

            int itemIndex = pageIndex != 0 ? pageItemsCount * pageIndex - 1 : 0;

            if (pageIndex > pageCount)
            {
                throw new Exception("Geçersiz parametre / istek");
            }

            using (TContext context = new TContext())
            {
                response = filter == null ? await filtreYok() : await filtreVar();

                // local function
                async Task<List<TEntity>> filtreYok()
                {
                    return await context.Set<TEntity>().OrderBy(p => p.ID).Skip(itemIndex).Take(pageItemsCount).ToListAsync();
                }

                async Task<List<TEntity>> filtreVar()
                {
                    return await context.Set<TEntity>().OrderBy(p => p.ID).Where(filter).Skip(itemIndex).Take(pageItemsCount).ToListAsync();
                }

            }
            return response;
        }

    }
}
