using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;
using CL.BookShop.IDAL;
using CL.BookShop.DAL;
using CL.BookShop.Model;

namespace CL.BookShop.DALFactory
{
    /// <summary>
    /// 抽象共厂：完成对象创建（反射）
    /// </summary>
    public class AbstractFactory
    {
        /// <summary>
        /// 程序集名称
        /// </summary>
        private static readonly string DalAssemblyPath = ConfigurationManager.AppSettings["DalAssemblyPath"];

        /// <summary>
        /// 命名空间
        /// </summary>
        private static readonly string NameSpace = ConfigurationManager.AppSettings["NameSpace"];

        /// <summary>
        /// 根据程序集名称，跟传入的类名，放回对应的类实例
        /// </summary>
        /// <param name="assemblyPath">程序集名称</param>
        /// <param name="fullClassName">类全名</param>
        /// <returns></returns>
        private static object CreateInstance(string assemblyPath,string fullClassName)
        {
            //加载程序集
            var assembly = Assembly.Load(assemblyPath);
            //返回程序集下的类
            return assembly.CreateInstance(fullClassName, true);

        }

        /// <summary>
        /// 返回一个包含UserInfoDAL实例的IUserInfoDAL接口
        /// </summary>
        /// <returns></returns>
        public static  IUserInfoDAL GetIUserInfoDalInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".UserInfoDAL") as IUserInfoDAL;
        }
    }
}
