using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace Mapping
{
    public class SysPermissionMap:EntityTypeConfiguration<Domain.SysPermission>
    {
        public SysPermissionMap()
        {
            ToTable("SysPermission");
            //配置与Module 一对多关系
            this.HasRequired(p => p.Module).WithMany(p => p.Permissions).HasForeignKey(p => p.ModuleId);
        }
    }
}
