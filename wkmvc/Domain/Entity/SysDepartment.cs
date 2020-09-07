using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SysDepartment : ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public SysDepartment()
        {
            Posts = new HashSet<SysPost>();
        }
        public int Id { get; set; }
        /// <summary>
        /// 部门编号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 业务等级
        /// </summary>
        public int BusinessLevel { get; set; }
        /// <summary>
        /// 部门排序
        /// </summary>
        public int ShowOrder { get; set; }
        /// <summary>
        /// 上级部门
        /// </summary>
        public int ParentId { get; set; }
        public int CreateUserId { get;set; }
        public DateTime CreateDate { get;set; }
        public int? UpdateUserId { get;set; }
        public DateTime? UpdateDate { get;set; }
        public bool? DeleteMark { get;set; }
        public int? DeleteUserId { get;set; }
        public DateTime? DeleteDate { get;set; }
        public virtual ICollection<SysPost> Posts { get; set; }
        public virtual ICollection<SysUser> Users { get; set; }

    }
}
