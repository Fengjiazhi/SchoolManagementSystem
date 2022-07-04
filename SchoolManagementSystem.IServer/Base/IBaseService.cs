using SchoolManagementSystem.Model.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolManagementSystem.IServer
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        Task<List<TEntity>> Query(string sql, TEntity entity);

        Task<List<TEntity>> Query(string sql, object obj);

        Task<TEntity> QueryScalar(string sql, object obj);

        Task<MessageModel<CurdModel>> NonQuery(string sql, TEntity entity);

        Task<MessageModel<CurdModel>> NonQuery(string sql, object obj);
    }
}
