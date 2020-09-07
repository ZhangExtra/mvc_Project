using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace Mapping
{
    public class SysRoleMap:EntityTypeConfiguration<Domain.SysRole>
    {
        public SysRoleMap()
        {
            ToTable("SysRole");
            this.HasMany(p => p.Permissions).WithMany(p => p.Roles).Map(p =>
            {
                p.ToTable("SysRolePermission");
                p.MapLeftKey("RoleId");
                p.MapRightKey("PermissionId");
            });
        }
    }
}
