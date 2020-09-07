using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SysRole : ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public SysRole()
        {
            Permissions = new HashSet<SysPermission>();
        }
        public int Id { get;set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 是否自定义
        /// </summary>
        public int IsCustom { get; set; }
        /// <summary>
        /// 角色说明
        /// </summary>        
        public string RoleDesc { get; set; }
        public int CreateUserId { get;set; }
        public DateTime CreateDate { get;set; }
        public int? UpdateUserId { get;set; }
        public DateTime? UpdateDate { get;set; }
        public bool? DeleteMark { get;set; }
        public int? DeleteUserId { get;set; }
        public DateTime? DeleteDate { get;set; }
        public virtual ICollection<SysPermission> Permissions { get; set; }
        public virtual ICollection<SysUser> Users { get; set; }

    }
}
