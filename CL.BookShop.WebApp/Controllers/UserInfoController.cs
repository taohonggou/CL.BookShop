using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CL.BookShop.WebApp.Controllers
{
    public class UserInfoController : Controller
    {
        // GET: UserInfo
        public ActionResult Index()
        {
            IBLL.IUserInfoService userInfoService = new BLL.UserInfoService();
            var users = userInfoService.LoadEntities(c => true);
            ViewData.Model = users;
            return View();
        }
    }
}