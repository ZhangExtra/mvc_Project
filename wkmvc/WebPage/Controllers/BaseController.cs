using Service;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Common;
namespace WebPage.Controllers
{
    public class BaseController : Controller
    {
        #region 公用变量
        /// <summary>
        /// 查询关键字
        /// </summary>
        public string keywords { get; set; }
        /// <summary>
        /// 视图传递的分页页码
        /// </summary>
        public int page { get; set; }
        /// <summary>
        /// 每页显示条数
        /// </summary>
        public int pagesize { get; set; }
        /// <summary>
        /// 用户容器 公用
        /// </summary>
        public IUserManage UserManage = Spring.Context.Support.ContextRegistry.GetContext().GetObject("Service.User") as IUserManage;
        #endregion

        #region 用户对象
        public Account CurrentUser
        {
            get
            {
                //从Session获取用户对象
                if (SessionHelper.GetSession("CurrentUser") != null)
                {
                    return SessionHelper.GetSession("CurrentUser") as Account;
                }
                var account = UserManage.GetAccountByCookie();
                SessionHelper.SetSession("CurrentUser", account);
                return account;
            }
        }
        #endregion

        #region 登录用户验证
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
        #endregion


    }
}