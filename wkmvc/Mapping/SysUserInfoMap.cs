using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
namespace Mapping
{
    public class SysUserInfoMap:EntityTypeConfiguration<Domain.SysUserInfo>
    {
        public SysUserInfoMap()
        {
            ToTable("SysUserInfo");
            this.HasRequired(p => p.User).WithMany().HasForeignKey(p => p.UserId);
        }
    }
}
