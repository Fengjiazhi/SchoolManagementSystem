using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model.ViewModel
{
    /// <summary>
    /// 权限表
    ///</summary>
    public class PowerModel
    {
        /// <summary>
        /// 主键id 
        ///</summary>
        public int Id { get; set; }
        /// <summary>
        /// 权限名称 
        ///</summary>
        public string PowerName { get; set; }
        /// <summary>
        /// 页面地址 
        ///</summary>
        public string PowerPath { get; set; }
        /// <summary>
        /// 父级id 
        ///</summary>
        public int PowerPid { get; set; }
        /// <summary>
        /// 权限图标
        ///</summary>
        public string PowerIcon { get; set; }
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
