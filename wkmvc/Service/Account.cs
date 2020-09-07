using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LogName { get; set; }
        public string PassWord { get; set; }
        public bool IsAdmin { get; set; }
        public string FaceImg { get; set; }
        /// <summary>
        /// 用户主部门
        /// </summary>
        public Domain.SysDepartment DepartmentInfo { get; set; }
        /// <summary>
        /// 用户部门集合
        /// </summary>
        public List<Domain.SysDepartment> Departments { get; set; }
        /// <summary>
        /// 权限集合
        /// </summary>
        public List<Domain.SysPermission> Permissions { get; set; }
        /// <summary>
        /// 角色集合
        /// </summary>
        public List<Domain.SysRole> Roles { get; set; }
        /// <summary>
        /// 岗位集合
        /// </summary>
        public List<Domain.SysPost> Posts { get; set; }
        /// <summary>
        /// 用户可操作模块集合
        /// </summary>
        public List<Domain.SysModule> Modules { get; set; }
    }
}
