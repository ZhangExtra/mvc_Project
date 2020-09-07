using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface ICreationAudited
    {
        /// <summary>
        /// 主键
        /// </summary>
        int Id { get; set; }
        int CreateUserId { get; set; }
        DateTime CreateDate { get; set; }
       
    }
}
