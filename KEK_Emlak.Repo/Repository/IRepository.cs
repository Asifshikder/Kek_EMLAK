using KEK_Emlak.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KEK_Emlak.Repo.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAllIEnumerable();
        List<T> GetAll();
        T Get(int id);
        Task<T> GetAsync(int id);
        Task InsertAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        void Delete(T entity);
        void Insert(T entity);
        void Update(T entity);
        int count();

    }
}
