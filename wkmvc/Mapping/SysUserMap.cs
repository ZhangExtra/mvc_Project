using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Domain;
namespace Mapping
{
    public class SysUserMap : EntityTypeConfiguration<SysUser>
    {
        public SysUserMap()
        {
            ToTable("SysUser");           
            Property(p => p.PinYin1).IsUnicode(false);
            Property(p => p.PinYin2).IsUnicode(false);
            Property(p => p.PassWord).IsUnicode(false);
            Property(p => p.Account).IsUnicode(false);
            Property(p => p.FaceImg).IsUnicode(false);
            Property(p => p.Levels).IsUnicode(false);

            this.HasMany(p => p.Permissions).WithMany(p => p.Users).Map(p =>
            {
                p.ToTable("SysUserPermission");
                p.MapLeftKey("UserId");
                p.MapRightKey("PermissionId");
            });
            this.HasMany(p => p.Departments).WithMany(p => p.Users).Map(p =>
            {
                p.ToTable("SysUserDepartment");
                p.MapLeftKey("UserId");
                p.MapRightKey("DepartmentId");
            });
            this.HasMany(p => p.Roles).WithMany(p => p.Users).Map(p =>
            {
                p.ToTable("SysUserRole");
                p.MapLeftKey("UserId");
                p.MapRightKey("RoleId");
            });
            this.HasMany(p => p.Posts).WithMany(p => p.Users).Map(p =>
            {
                p.ToTable("SysUserPost");
                p.MapLeftKey("UserId");
                p.MapRightKey("PostId");
            });
        }
    }
}
