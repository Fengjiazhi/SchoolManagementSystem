using SchoolManagementSystem.Common.Helper;
using SchoolManagementSystem.IRepository.Base;
using SchoolManagementSystem.IServer;
using SchoolManagementSystem.Model.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Server
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class, new()
    {
        private readonly IBaseRepository<TEntity> baseDal;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            baseDal = baseRepository;
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql</param>
        /// <param name="entity">T</param>
        /// <returns></returns>
        public virtual async Task<List<TEntity>> Query(string sql, TEntity entity)
        {
            return await baseDal.Query(sql, entity);
        }
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql</param>
        /// <param name="obj">new {}</param>
        /// <returns></returns>
        public virtual async Task<List<TEntity>> Query(string sql, object obj)
        {
            return await baseDal.Query(sql, obj);
        }
        /// <summary>
        /// 查询第一行第一列的数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql</param>
        /// <param name="obj">new {}</param>
        /// <returns></returns>
        public virtual async Task<TEntity> QueryScalar(string sql, object obj)
        {
            return await baseDal.QueryScalar(sql, obj);
        }
        /// <summary>
        /// 执行增，删，改 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql</param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<MessageModel<CurdModel>> NonQuery(string sql, TEntity entity)
        {
            var result = await baseDal.NonQuery(sql, entity);
            if (result > 0)
            {
                return HttpResult.Ok();
            }
            else
            {
                return HttpResult.DbError("执行失败!");
            }
        }
        /// <summary>
        /// 执行增，删，改 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql</param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<MessageModel<CurdModel>> NonQuery(string sql, object obj)
        {
            var result = await baseDal.NonQuery(sql, obj);
            if (result > 0)
            {
                return HttpResult.Ok();
            }
            else
            {
                return HttpResult.DbError("执行失败!");
            }
        }
    }
}
