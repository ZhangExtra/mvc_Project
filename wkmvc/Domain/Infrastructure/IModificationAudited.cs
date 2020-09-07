using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IModificationAudited
    {
        int ? UpdateUserId { get; set; }
        DateTime ? UpdateDate { get; set; }
    }
}
