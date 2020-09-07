using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SysModule : ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public int Id { get; set; }
        /// <summary>
        /// 所属系统
        /// </summary>
        public string FkBelongSystem { get; set; }
        /// <summary>
        /// 父级菜单
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// 显示名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 别名
        /// </summary>
        public string Alias { get; set; }
        /// <summary>
        /// 模块类型
        /// </summary>
        public int ModuleType { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// 模块连接
        /// </summary>
        public string ModulePath { get; set; }
        /// <summary>
        /// 是否显示
        /// </summary>
        public int IsShow { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int ShowOrder { get; set; }
        /// <summary>
        /// 级别
        /// </summary>
        public int Levels { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsVillage{get;set;}
        public virtual ICollection<SysPermission> Permissions { get; set; }
        public int CreateUserId { get;set; }
        public DateTime CreateDate { get;set; }
        public int? UpdateUserId { get;set; }
        public DateTime? UpdateDate { get;set; }
        public bool? DeleteMark { get;set; }
        public int? DeleteUserId { get;set; }
        public DateTime? DeleteDate { get;set; }
    }
}
