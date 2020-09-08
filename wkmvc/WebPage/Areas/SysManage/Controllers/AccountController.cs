using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service.IService;
using Common;
using log4net;
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

        #region 基本视图
        // GET: SysManage/Account
        public ActionResult Index()
        {
            LogHelper.Default.WriteInfo("AppStart");
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password, string code)
        {
            LogHelper.Default.WriteInfo("AppStart");
            var json = new JsonHelper() { Msg = "登录成功", Status = "n" };
            try
            {
                if (Session["gif"] != null)
                {
                    if (!String.IsNullOrEmpty(code) && code.ToLower() == Session["gif"].ToString().ToLower())
                    {
                        //调用登录验证接口 返回用户实体类
                        var users = UserManage.UserLogin(username, password);
                        if (users != null)
                        {
                            //是否锁定
                            if (users.IsCanLogin)
                            {
                                json.Msg = "用户已锁定，禁止登录，请联系管理员进行解锁";
                                return Json(json);
                            }
                            var account = this.UserManage.GetAccountByUser(users);
                            //写入Session到当前登陆用户中
                            SessionHelper.SetSession("CurrentUser",account);
                            //记录用户信息到Cookies
                            string cookievalue = $"{{\"id\":\"{account.Id}\",\"username\":\"{account.LogName}\",\"token\":\"{Session.SessionID}\"}}";
                            users.LastLoginIp = Utils.GetIP();
                            UserManage.Update(users);
                            json.Status = "y";
                            json.ReUrl = "/Sys/Home/Index";
                        }
                        else
                        {
                            json.Msg = "用户名或密码不正确";
                        }
                    }
                    else {
                        json.Msg = "验证码不正确";
                    }
                }
                else {
                    json.Msg = "验证码已失效,请刷新验证码";
                  
                }
            }
            catch (Exception e)
            {
                json.Msg = e.Message;
            }
            return Json(json, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 帮助方法
        /// <summary>
        /// 验证码
        /// </summary>
        /// <returns></returns>
        public FileContentResult ValidateCode()
        {
            string code = "";
            System.IO.MemoryStream ms = new Models.verify_code().Create(out code);
            Session["gif"] = code;
            Response.ClearContent();
            return File(ms.ToArray(),@"image/png");
        }
        #endregion

    }
}