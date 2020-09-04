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
        }
    }
}
