using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service.IService;
using Common;
namespace WebPage.Areas.SysManage.Controllers
{
    public class AccountController : Controller
    {
        #region 声明容器
        /// <summary>
        /// 用户管理
        /// </summary>
        IUserManage UserManage { get; set; }
        #endregion

        // GET: SysManage/Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(Domain.Entity.SysUser item)
        {
            var json = new JsonHelper() {Msg="登录成功",Status="n" };
            try
            {
                //调用登录验证接口 返回用户实体类
                var users = UserManage.UserLogin(item.Account.Trim(), item.PassWord.Trim());
                if (users != null)
                {
                    //是否锁定
                    if (users.IsCanLogin)
                    {
                        json.Msg = "用户已锁定，禁止登录，请联系管理员进行解锁";
                        return Json(json);
                    }
                    json.Status = "y";

                }
                else
                {
                    json.Msg = "用户名或密码不正确";
                }

            }
            catch (Exception e)
            {
                json.Msg = e.Message;
            }
            return Json(json, JsonRequestBehavior.AllowGet);
        }
    }
}