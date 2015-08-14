﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CL.BookShop.WebApp.Controllers
{
    public class UserInfoController : Controller
    {

        IBLL.IUserInfoService userInfoService = new BLL.UserInfoService();
        // GET: UserInfo
        public ActionResult Index()
        {
            //IBLL.IUserInfoService userInfoService = new BLL.UserInfoService();
            //var users = userInfoService.LoadEntities(c => true);
            //ViewData.Model = users;
            return View();
        }

        /// <summary>
        /// 获取数据
        /// </summary>
        /// <returns></returns>
        public ActionResult GetUserInfo()
        {
            int pageIndex;
            int pageSize;
            if (!int.TryParse(Request["page"], out pageIndex))
            {
                pageIndex = 1;
                
            }
            if (!int.TryParse(Request["rows"],out pageSize))
            {
                pageSize = 5;
            }
            
            int totalCount;
            var users= userInfoService.LoadPageEntities<int>(pageIndex, pageSize, out totalCount, u => true, u => u.ID, true);
            var rows = from u in users
                       select new { ID = u.ID, UserName = u.UserName, UserPass = u.UserPass, Email = u.Email, RegTime = u.RegTime };
            return Json(new {total=totalCount,rows=rows },JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 删除用户数据
        /// </summary>
        /// <returns></returns>
        public ActionResult DeleteInfo()
        {
            string strId = Request["strId"];
            string[] strs = strId.Split(',');
            List<int> list = new List<int>();
            foreach (string  Id in strs)
            {
                list.Add(Convert.ToInt32(Id));
            }
            //这里批量删除
            if (userInfoService.DeleteEntities(list))
            {
                return Content("ok");
            }
            else
            {
                return Content("no");
            }
        }
    }
} 