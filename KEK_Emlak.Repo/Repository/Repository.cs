using KEK_Emlak.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEK_Emlak.Repo.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {

        private readonly ApplicationDbContext context;
        public Repository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Delete(T entity)
        {

            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public async Task DeleteAsync(T entity)
        {
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public T Get(int id)
        {
            return context.Set<T>().SingleOrDefault(s => s.Id == id);
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public IEnumerable<T> GetAllIEnumerable()
        {
            return context.Set<T>().AsEnumerable();
        }

        public IQueryable<T> GetAllIQueryble()
        {
            return context.Set<T>().AsQueryable();
        }

        public async Task<T> GetAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public void Insert(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public async Task InsertAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public async Task UpdateAsync(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
        public void Dispose()
        {
            context.Dispose();
            GC.SuppressFinalize(this);
        }

        public int count()
        {
            return context.Set<T>().Count();
        }
    }
}
