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

        [HttpGet]
        public async Task<List<UserModel>> GetUsers() 
        {
            UserModel UserModel = new UserModel();
            string sql = "SELECT Id,Username,Password,Status,CreateTime,UpdateTIme FROM UserModel";
            return await _userService.Query(sql, UserModel);
        }


    }
}
