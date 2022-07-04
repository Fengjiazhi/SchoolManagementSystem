using SchoolManagementSystem.Repository.Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Repository.Base
{
    public class BaseRepository<TEntity> where TEntity : class, new()
    {
        public static DapperDbContext _DapperDb;
        public BaseRepository(DapperDbContext DapperDB)
        {
            _DapperDb= DapperDB;
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql</param>
        /// <param name="entity">T</param>
        /// <returns></returns>
        public async Task<List<TEntity>> Query(string sql, TEntity entity)
        {                       
            return await Task.Run(() =>
            {
                List<TEntity> list = new List<TEntity>();
                return list = _DapperDb.Query<TEntity>(sql, entity).ToList();
            });
        }
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql</param>
        /// <param name="obj">new {}</param>
        /// <returns></returns>
        public async Task<List<TEntity>> Query(string sql, object obj)
        {
            return await Task.Run(() =>
            {
                List<TEntity> list = new List<TEntity>();
                return list = _DapperDb.Query<TEntity>(sql, obj).ToList();
            });
        }
        /// <summary>
        /// 查询第一行第一列的数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql</param>
        /// <param name="obj">new {}</param>
        /// <returns></returns>
        public async Task<TEntity> QueryScalar(string sql, object obj)
        {
            return await Task.Run(() =>
            {
                TEntity result = default(TEntity);
                return result = _DapperDb.QueryScalar<TEntity>(sql, obj);
            }); 
        }      
        /// <summary>
        /// 执行增，删，改 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql</param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<int> NonQuery(string sql, TEntity entity)
        {
            return await Task.Run(() =>
            {
                int res = 0;
                return res = _DapperDb.NonQuery(sql, entity);
            });
        }
        /// <summary>
        /// 执行增，删，改 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql</param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<int>  NonQuery(string sql, object obj)
        {
            return await Task.Run(() =>
            {
                int res = 0;
                return res = _DapperDb.NonQuery(sql, obj);
            });
        }
    }
}
