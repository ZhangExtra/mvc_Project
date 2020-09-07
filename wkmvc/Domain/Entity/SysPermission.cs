using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SysPermission : ICreationAudited, IModificationAudited, IDeleteAudited
    {
        public int Id { get; set; }
        /// <summary>
        /// 模块ID
        /// </summary>
        public int ModuleId { get; set; }
        public virtual SysModule Module { get; set; }
        /// <summary>
        /// 授权名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 权限值
        /// </summary>
        public string PerValue { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// 显示排序
        /// </summary>
        public int ShowOrder { get; set; }
        public int CreateUserId { get;set; }
        public DateTime CreateDate { get;set; }
        public int? UpdateUserId { get;set; }
        public DateTime? UpdateDate { get;set; }
        public bool? DeleteMark { get;set; }
        public int? DeleteUserId { get;set; }
        public DateTime? DeleteDate { get;set; }
        public virtual ICollection<SysRole> Roles { get; set; }
        public virtual ICollection<SysUser> Users { get; set; }


    }
}
