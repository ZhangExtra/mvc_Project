using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SysCode : ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public int Id { get; set; }
        /// <summary>
        /// 父级ID
        /// </summary>
        public int ParentId { get; set; }
        /// <summary>
        /// 代码类型
        /// </summary>
        public string CodeType { get; set; }
        /// <summary>
        /// 代码显示文本
        /// </summary>
        public string NameText { get; set; }
        /// <summary>
        /// 代码值
        /// </summary>
        public string CodeValue { get; set; }
        /// <summary>
        /// 排序值
        /// </summary>
        public int ShowOrder { get; set; }
        /// <summary>
        /// 是否为编码 1：是 0：否
        /// </summary>
        public int IsCode { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime ? UpdateDate { get; set; }
        public bool? DeleteMark { get; set; }
        public int? DeleteUserId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
