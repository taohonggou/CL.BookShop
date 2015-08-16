using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CL.BookShop.Common;
using CL.BookShop.Model;

namespace CL.BookShop.WebApp.Controllers
{
    public class HomeController : Controller
    {
        IBLL.IUsersService userService=new BLL.UsersService();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {
            return View();
        }

        /// <summary>
        /// 这里有待完成
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        //public ActionResult Register(Users user)
        //{
        //    if (CheckValidateCode())
        //    {
        //        user.UserStateId = 1;
        //        string msg = string.Empty;
        //        if (userService.AddEntity(user, out msg)!=null)
        //        {
        //            //RedirectToAction("ShowMsg",);
        //        } 

        //    }
        //    else
        //    {
        //        //验证码错误
        //    }
        //}

        /// <summary>
        /// 完成验证码校验
        /// </summary>
        /// <returns></returns>
        private bool CheckValidateCode()
        {
            if (Session["validateCode"] !=null)
            {
                string txtCode = Request["txtCode"];
                string sysCode = Session["validateCode"].ToString();
                if (sysCode.Equals(txtCode,StringComparison.InvariantCultureIgnoreCase))
                {
                    Session["validateCode"] = null;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 呈现验证码
        /// </summary>
        /// <returns></returns>
        public ActionResult GetVerificCode()
        {
            ValidateCode vCode = new ValidateCode();
            string code = vCode.CreateValidateCode(4);
            Session["validateCode"] = code;
            byte[] buffer = vCode.CreateValidateGraphic(code);
            return File(buffer, "image/jpeg");
        }
    }
}