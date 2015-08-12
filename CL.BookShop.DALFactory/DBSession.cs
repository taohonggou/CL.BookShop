﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL.BookShop.Model;
using CL.BookShop.IDAL;
using CL.BookShop.DAL;
using System.Data.SqlClient;
using System.Data.Entity;

namespace CL.BookShop.DALFactory
{
    /// <summary>
    /// 数据访问会话层，赋值创建所有的数据操作类对象，业务层只要获取到DBSession，就拿到了所有的数据操作类的实例，让业务层与数据层解耦
    /// </summary>
     public class DBSession:IDBSession
    {
        //DbContext db = new book_shop3Entities();

        public DbContext Db { get { return DbContextFactory.GetCurrentDbContext(); } }
        private IUserInfoDAL _userInfoDAL;

        public IUserInfoDAL UserInfoDAL
        {
            get
            {
                if (_userInfoDAL==null)
                {
                   return  _userInfoDAL;
                }
                return _userInfoDAL;
            }

            set
            {//抽象工厂  用于创建包含UserInfoDAL实例的IUserInfoDAL接口
                _userInfoDAL = AbstractFactory.GetIUserInfoDalInstance();
            }
        }

        /// <summary>
        /// 执行sql语句  特殊的
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public int ExecuteSql(string sql, params SqlParameter[] param)
        {
            return Db.Database.ExecuteSqlCommand(sql, param);
        }

        /// <summary>
        /// 一个业务可能涉及到多张表操作，先将要修改的数据添加到上下文中，最后调用该方法一次性将数据保存到数据库中，避免了多次连接数据库
        /// </summary>
        /// <returns></returns>
        public int SaveChanges()
        {
            return Db.SaveChanges();
        }
    }
}