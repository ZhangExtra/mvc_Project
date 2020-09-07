using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SysCodeArea : ICreationAudited, IDeleteAudited, IModificationAudited
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public string Name { get; set; }
        public byte levels { get; set; }
        public int CreateUserId { get; set; }
        public DateTime CreateDate { get; set; }
        public int? UpdateUserId { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? DeleteMark { get; set; }
        public int? DeleteUserId { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
