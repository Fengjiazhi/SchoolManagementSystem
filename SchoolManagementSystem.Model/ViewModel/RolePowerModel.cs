using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model.ViewModel
{
    /// <summary>
    /// 角色权限表
    ///</summary>
    public class RolePowerModel
    {
        /// <summary>
        /// 主键id 
        ///</summary>
        public int Id { get; set; }
        /// <summary>
        ///  
        ///</summary>
        public int? RoleId { get; set; }
        /// <summary>
        ///  
        ///</summary>
        public int? PowerId { get; set; }
    }
}
