using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace Mapping
{
    public class SysPostMap:EntityTypeConfiguration<Domain.SysPost>
    {
        public SysPostMap()
        {
            ToTable("SysPost");
  
        }
    }
}
