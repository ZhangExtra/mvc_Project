using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Data;
using Domain;
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
        /// <summary>
        /// 获取奔部门名称
        /// </summary>
        string GetUserDeptName(int userId);
        /// <summary>
        /// 删除用户
        /// </summary>
        bool Remove(int userId);
        /// <summary>
        /// 根据用户构造用户基本信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Account GetAccountByUser(Domain.SysUser user);
        /// <summary>
        /// 从Cookie获取用户信息
        /// </summary>
        Account GetAccountByCookie();
    }
}
