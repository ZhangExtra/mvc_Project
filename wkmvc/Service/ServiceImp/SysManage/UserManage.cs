using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Domain.Entity;
namespace Service.ServiceImp
{
    public class UserManage : RepositoryBase<SysUser>, IService.IUserManage
    {
        public string GetUserName(int userId)
        {
            var entity = this.Get(p => p.Id == userId);
            if (entity != null)
            {
                return entity.Name;
            }
            return "";
        }

        public bool IsAdmin(int userId)
        {
            return true; 
        }

        public SysUser UserLogin(string useraccount, string password)
        {
            var entity = this.Get(p => p.Account == useraccount);
            //登录使用AES动态加密算法，没有统一的钥匙，两次字符串加密后的结果不一样 只能使用解密来匹配
            if (entity != null && password == new Common.CryptHelper.AESCrypt().Decrypt(entity.PassWord))
            {
                return entity;
            }
            return null;
        }
    }
}
