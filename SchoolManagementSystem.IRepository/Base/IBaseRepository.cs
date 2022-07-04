using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.IRepository.Base
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<List<TEntity>> Query(string sql, TEntity entity);
        Task<List<TEntity>> Query(string sql, object obj);
        Task<TEntity> QueryScalar(string sql, object obj);
        Task<int> NonQuery(string sql, TEntity entity);
        Task<int> NonQuery(string sql, object obj);
    }
}
