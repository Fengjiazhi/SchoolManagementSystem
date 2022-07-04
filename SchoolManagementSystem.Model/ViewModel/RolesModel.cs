using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model.ViewModel
{
    /// <summary>
    /// 角色表
    ///</summary>
    public class RolesModel
    {
        /// <summary>
        /// 主键 
        ///</summary>
        public int Id { get; set; }
        /// <summary>
        /// 角色名称 
        ///</summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 状态 
        ///</summary>
        public int? Status { get; set; }
        /// <summary>
        /// 创建时间 
        ///</summary>
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 更新时间 
        ///</summary>
        public DateTime? UpdateTime { get; set; }
    }
}
