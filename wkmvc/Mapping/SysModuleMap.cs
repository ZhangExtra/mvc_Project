using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace Mapping
{
    public class SysModuleMap:EntityTypeConfiguration<Domain.SysModule>
    {
        public SysModuleMap()
        {
            ToTable("SysModule");
        }
    }
}
