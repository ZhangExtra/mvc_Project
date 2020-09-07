using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SysUserInfo: ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual SysUser User { get; set; }
        /// <summary>
        /// 职务
        /// </summary>
        public int PostCode { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 办公电话
        /// </summary>
        public string OfficePhone { get; set; }
        /// <summary>
        /// 邮箱地址
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// 第二手机号
        /// </summary>
        public string SecondPhone { get; set; }
        /// <summary>
        /// 在岗状态，编码
        /// </summary>
        public int WorkCode { get; set; }
        /// <summary>
        /// 性别，编码
        /// </summary>
        public int SexCode { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime BirthDay { get; set; }
        /// <summary>
        /// 民族，编码
        /// </summary>
        public int NationCode { get; set; }
        /// <summary>
        /// 身份证号码
        /// </summary>
        public string IdNumber { get; set; }
        /// <summary>
        /// 婚姻，编码
        /// </summary>
        public int MarryCode { get; set; }
        /// <summary>
        /// 政治面貌，编码
        /// </summary>
        public int IdentityCode { get; set; }
        /// <summary>
        /// 籍贯，编码（关联至TBCode_Area的CodeValue）
        /// </summary>
        public string HomeTown { get; set; }
        public int CreateUserId { get;set; }
        public DateTime CreateDate { get;set; }
        public int? UpdateUserId { get;set; }
        public DateTime? UpdateDate { get;set; }
        public bool? DeleteMark { get;set; }
        public int? DeleteUserId { get;set; }
        public DateTime? DeleteDate { get;set; }        
        
    }
}
