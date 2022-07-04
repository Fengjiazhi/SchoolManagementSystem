using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolManagementSystem.Common.Redis;
using SchoolManagementSystem.IServer;
using SchoolManagementSystem.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using NLog;
using NLog.Extensions.Logging;
using log4net;
using SchoolManagementSystem.Model.ViewModel;
using SchoolManagementSystem.Model.Model;

namespace SchoolManagementSystem.web.Controllers
{
    public class UserController : BaseController
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;
        private readonly IRedisCacheManager _IRedisCacheManager;
        //private ILog log = log4net.LogManager.GetLogger(Startup.repository.Name, typeof(UserController));
        public UserController(ILogger<UserController> logger, IUserService userService, IRedisCacheManager RedisCacheManager)
        {
            _logger = logger;
            _userService = userService;
            _IRedisCacheManager = RedisCacheManager;
        }

        /// <summary>
        /// 查询所有User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("/User/Get/GetUsers")]
        public async Task<List<UserModel>> GetUsers(string id = "")
        {
            UserModel UserModel = new UserModel();
            string sql = "SELECT top(100) Id,Username,Password,Status,CreateTime,UpdateTIme FROM UserModel where 1=1  ";
            if (!string.IsNullOrEmpty(id) == true)
            {
                sql += " and Id=" + id;
            }
            return await _userService.Query(sql, UserModel);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/User/Delete/DelUsers/{id?}")]
        public async Task<MessageModel<CurdModel>> DelUsers(string id)
        {
            UserModel UserModel = new UserModel();
            string sql = "";
            if (!string.IsNullOrEmpty(id) == true)
            {
                sql += "DELETE FROM UserModel where 1=1 and Id=" + id;
            }
            return await _userService.NonQuery(sql, UserModel);
        }

        /// <summary>
        /// 增加用户
        /// </summary>
        /// <param name="Username"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/User/Post/AddUser/{Username?}/{Password?}")]
        public async Task<MessageModel<CurdModel>> AddUser(string Username,string Password) 
        {
            UserModel UserModel = new UserModel();
            UserModel.Username = Username;
            UserModel.Password = Common.Helper.MD5Helper.MD5Encrypt16(Password);
            UserModel.Status = 1;
            UserModel.CreateTime = System.DateTime.Now;
            UserModel.UpdateTIme = System.DateTime.Now;
            string sql = " INSERT INTO UserModel(Username,Password,Status,CreateTime,UpdateTIme) VALUES (@Username,@Password,@Status,@CreateTime,@UpdateTIme)";
            return await _userService.NonQuery(sql, UserModel);
        }




    }
}
