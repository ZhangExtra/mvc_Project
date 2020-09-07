using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SysUser:ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Account { get; set; }
        public string PassWord { get; set; }
        public bool IsCanLogin { get; set; }
        public int ShowOrder1 { get; set; }
        public int ShowOrder2 { get; set; }
        public string PinYin1 { get; set; }
        public string PinYin2 { get; set; }
        public string FaceImg { get; set; }
        public string Levels { get; set; }
        public int DeptId { get; set; }
        public string LastLoginIp { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public int ? UpdateUserId { get; set; }
        public DateTime ? UpdateDate { get; set; }
        public bool? DeleteMark { get; set; }
        public int? DeleteUserId { get; set; }
        public DateTime? DeleteDate { get; set; }
        public virtual ICollection<SysPost> Posts { get; set; }
        public virtual ICollection<SysDepartment> Departments { get; set; }
        public virtual ICollection<SysPermission> Permissions { get; set; }
        public virtual ICollection<SysRole> Roles { get; set; }
    }
}

