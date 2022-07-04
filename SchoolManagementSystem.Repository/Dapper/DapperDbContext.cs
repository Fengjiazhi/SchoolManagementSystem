using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Repository.Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;
using Dapper;

namespace SchoolManagementSystem.Repository.Dapper
{
    public class DapperDbContext
    {
        static string sqlconnection = BaseDBConfig.ConnectionString;
        public SqlConnection _OpenConnection;
        public static SqlConnection OpenConnection()
        {
            SqlConnection connection = new SqlConnection(sqlconnection);  //这里sqlconnection就是数据库连接字符串
            connection.Open();
            return connection;
        }
        
        #region 查询数据
        /// <summary>
        /// 查询数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql</param>
        /// <param name="entity">T</param>
        /// <returns></returns>
        public  List<T> Query<T>(string sql, T entity)
        {
            List<T> list = new List<T>();
            using (IDbConnection conn = OpenConnection())
            {
                list = conn.Query<T>(sql, entity).ToList();
            }
            return list;
        }


        /// <summary>
        /// 查询数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql</param>
        /// <param name="obj">new {}</param>
        /// <returns></returns>
        public List<T> Query<T>(string sql, object obj)
        {
            List<T> list = new List<T>();
            using (IDbConnection conn = OpenConnection())
            {
                list = conn.Query<T>(sql, obj).ToList();
            }
            return list;
        }

        /// <summary>
        /// 查询第一行第一列的数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql</param>
        /// <param name="obj">new {}</param>
        /// <returns></returns>
        public T QueryScalar<T>(string sql, object obj)
        {

            T result = default(T);

            using (IDbConnection conn = OpenConnection())
            {
                result = conn.ExecuteScalar<T>(sql, obj);
            }
            return result;
        }
        #endregion

        #region 执行增，删，改 
        /// <summary>
        /// 执行增，删，改 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql</param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int NonQuery<T>(string sql, T entity)
        {
            int res = 0;
            using (IDbConnection conn = OpenConnection())
            {
                res = conn.Execute(sql, entity);
            }
            return res;
        }

        /// <summary>
        /// 执行增，删，改 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql">sql</param>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static int NonQuery(string sql, object obj)
        {
            int res = 0;
            using (IDbConnection conn = OpenConnection())
            {
                res = conn.Execute(sql, obj);
            }
            return res;
        }
        #endregion

    }
}
