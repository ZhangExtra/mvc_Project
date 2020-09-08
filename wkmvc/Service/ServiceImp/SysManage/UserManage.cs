using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Data;
using Domain;
using Service.IService;

namespace Service.ServiceImp
{
    public class UserManage : RepositoryBase<SysUser>, IService.IUserManage
    {
        IDepartmentManage DepartmentManage { get; set; }
        IPermissionManage PermissionManage { get; set; }
        /// <summary>
        /// 从cookie获取用户信息
        /// </summary>
        /// <returns></returns>
        public Account GetAccountByCookie()
        {
            var cookie = CookieHelper.GetCookie("cookie_rememberme");
            if (cookie != null)
            {
                if (!string.IsNullOrEmpty(cookie.Value))
                {
                    //解密
                    var cookirvalue = new Common.CryptHelper.AESCrypt().Decrypt(cookie.Value);
                    if (!JsonSplit.IsJson(cookirvalue)) return null;
                    try
                    {
                        var jsonFormat = Common.JsonConverter.ConvertJson(cookirvalue);
                        if (jsonFormat != null) {
                            var user = UserLogin(jsonFormat.username,new Common.CryptHelper.AESCrypt().Decrypt(jsonFormat.password));
                            if (user != null)
                            {
                                return GetAccountByUser(user);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }
            return null;
        }
        /// <summary>
        /// 根据用户构造用户基本信息
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public Account GetAccountByUser(SysUser user)
        {
            if (user == null) return null;
            //用户授权
            var permission = GetPermissionByUser(user);
            //用户角色
            var role = user.Roles.ToList();
            //用户部门
            var dpt = user.Departments.ToList();
            //用户岗位
            var post = user.Posts.ToList();
            //用户主部门
            var dptinfo = DepartmentManage.Get(p=>p.Id==user.DeptId);
            //用户模块
            var module = permission.Select(p =>p.Module).ToList().Distinct(new ModuleDistinct()).ToList();
            Account account = new Account()
            {
                Id = user.Id,
                Name = user.Name,
                LogName = user.Account,
                PassWord = user.PassWord,
                IsAdmin = IsAdmin(user.Id),
                Departments= dpt,
                DepartmentInfo = dptinfo,
                FaceImg=user.FaceImg,
                Permissions=permission,
                Roles=role,
                Posts=post,
                Modules=module
            };
            return account;
        }
        /// <summary>
        /// 根据用户获取用户所有的权限
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private List<Domain.SysPermission> GetPermissionByUser(Domain.SysUser user)
        {
            //1、超管拥有所有权限
            if (IsAdmin(user.Id))
            {
                return PermissionManage.LoadListAll(null);
            }
            //2、普通用户，合并当前用户权限和角色权限
            var perlist = new List<Domain.SysPermission>();
            //2.1 合并用户权限
            perlist.AddRange(user.Permissions);
            //2.2 合并角色权限
            perlist.AddRange(user.Roles.SelectMany(p=>p.Permissions));
            //去重
            perlist = perlist.Distinct(new PermissionDistinct()).ToList();
            return perlist;
        }

        /// <summary>
        /// 获取用户部门
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public string GetUserDeptName(int userId)
        {
            return "";
        }

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
            SysUser entity = this.Get(p => p.Id == userId);
            if (entity == null) return false;
            return entity.Roles.Any(p => p.Id == ClsDic.DicRole["超级管理员"]);
        }

        public bool Remove(int userId)
        {
            //逻辑删除
            SysUser entity = this.Get(p => p.Id == userId);
            entity.DeleteMark = true;
            bool result=this.Update(entity);
            return result;
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

    /// <summary>
    /// 模块去重
    /// </summary>
    public  class ModuleDistinct : IEqualityComparer<SysModule>
    {
        public bool Equals(Domain.SysModule x, Domain.SysModule y)
        {
            return x.Id == y.Id;
        }
        public int GetHashCode(Domain.SysModule obj)
        {
            return obj.ToString().GetHashCode();
        }
    }
    /// <summary>
    /// 权限去重，非常重要
    /// </summary>
    public class PermissionDistinct : IEqualityComparer<Domain.SysPermission>
    {
        public bool Equals(Domain.SysPermission x, Domain.SysPermission y)
        {
            return x.Id == y.Id;
        }
        public int GetHashCode(Domain.SysPermission obj)
        {
            return obj.ToString().GetHashCode();
        }
    }
}
