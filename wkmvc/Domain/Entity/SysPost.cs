using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// 岗位
    /// </summary>
    public class SysPost: ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public SysPost()
        {
            Departments = new HashSet<SysDepartment>();
        }
        public int Id { get; set; }
        /// <summary>
        /// 岗位名称
        /// </summary>
        public string PostName { get; set; }
        /// <summary>
        /// 岗位类型
        /// </summary>
        public string PostType { get; set; }
        /// <summary>
        /// 岗位备注
        /// </summary>
        public string Remark { get; set; }
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
        public virtual ICollection<SysDepartment> Departments { get; set; }
        public virtual ICollection<SysUser> Users { get; set; }
    }
}
