using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model.ViewModel
{
    /// <summary>
    /// 用户表
    ///</summary>
    public class UserModel
    {
        /// <summary>
        /// 主键id 
        ///</summary>
        public int Id { get; set; }
        /// <summary>
        /// 用户名 
        ///</summary>
        public string Username { get; set; }

        /// <summary>
        /// 密码 
        ///</summary>
        public string Password { get; set; }

        /// <summary>
        /// 状态 0正常 1关闭 
        ///</summary>
        
        public int? Status { get; set; }
        /// <summary>
        /// 创建时间 
        ///</summary>

        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 更新时间 
        ///</summary>

        public DateTime? UpdateTIme { get; set; }
    }
}
