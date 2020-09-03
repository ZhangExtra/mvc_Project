using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class SysUser
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
        public string DeptId { get; set; }
        public string LastLoginIp { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}

