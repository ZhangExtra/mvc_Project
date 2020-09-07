using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SysSystem : ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public int Id { get;set; }
        /// <summary>
        /// 系统名称
        /// </summary>
        public string Name { get; set; }
       /// <summary>
       /// 系统地址
       /// </summary>
        public string SiteUrl { get; set; }
        /// <summary>
        /// 是否允许登录系统
        /// </summary>
        public byte IsLogin { get; set; }
        /// <summary>
        /// 系统对接用户名
        /// </summary>
        public string DockUser { get; set; }
        /// <summary>
        /// 系统对接地址
        /// </summary>
        public string DockPass { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        public int CreateUserId { get;set; }
        public DateTime CreateDate { get;set; }
        public int? UpdateUserId { get;set; }
        public DateTime? UpdateDate { get;set; }
        public bool? DeleteMark { get;set; }
        public int? DeleteUserId { get;set; }
        public DateTime? DeleteDate { get;set; }
    }
}
