using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace Mapping
{
    public class SysDepartmentMap : EntityTypeConfiguration<Domain.SysDepartment>
    {
        public SysDepartmentMap()
        {
            ToTable("SysDepartment");
            //配置对多对关系 部门 岗位
            this.HasMany(p => p.Posts).WithMany(p => p.Departments).Map(p =>
            {
                p.ToTable("SysPostDepartment");
                p.MapLeftKey("DepartmentId");
                p.MapRightKey("PostId");
            });
        }
    }
}
