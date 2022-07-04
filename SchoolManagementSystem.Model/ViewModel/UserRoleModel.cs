using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model.ViewModel
{
    /// <summary>
    /// 用户角色表
    ///</summary>
    public class UserRoleModel
    {

        /// <summary>
        /// 主键id 
        ///</summary>       
        public int Id { get; set; }
        /// <summary>
        /// 用户id 
        ///</summary>
        public int? UserId { get; set; }
        /// <summary>
        /// 角色id 
        ///</summary>
        public int? RoleId { get; set; }

    }
}
