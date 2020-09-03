using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Data;
using Domain.Entity;
namespace Service.IService
{
    public interface IUserManage:IRepository<SysUser>
    {
        /// <summary>
        /// 管理员登录验证 验证成功 返回信息与权限集合
        /// </summary>
        /// <param name="useraccount"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        SysUser UserLogin(string userccount, string password);
        /// <summary>
        /// 是否是超管
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        bool IsAdmin(int userId);
        /// <summary>
        /// 获取用户名称
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        string GetUserName(int userId);
    }
}
