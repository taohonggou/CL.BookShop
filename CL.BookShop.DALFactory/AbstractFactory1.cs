using System.Configuration;
using System.Reflection;
using CL.BookShop.IDAL;

namespace CL.BookShop.DALFactory
{
    /// <summary>
    /// 抽象共厂：完成对象创建（反射）
    /// </summary>
    public partial class AbstractFactory
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
        /// 返回一个包含ActionGroupDAL实例的IActionGroupDAL接口
        /// </summary>
        /// <returns></returns>
        public static  IActionGroupDAL GetIActionGroupDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".ActionGroupDAL") as IActionGroupDAL;
        }
		/// <summary>
        /// 返回一个包含ActionInfoDAL实例的IActionInfoDAL接口
        /// </summary>
        /// <returns></returns>
        public static  IActionInfoDAL GetIActionInfoDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".ActionInfoDAL") as IActionInfoDAL;
        }
		/// <summary>
        /// 返回一个包含Articel_WordsDAL实例的IArticel_WordsDAL接口
        /// </summary>
        /// <returns></returns>
        public static  IArticel_WordsDAL GetIArticel_WordsDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".Articel_WordsDAL") as IArticel_WordsDAL;
        }
		/// <summary>
        /// 返回一个包含BookCommentDAL实例的IBookCommentDAL接口
        /// </summary>
        /// <returns></returns>
        public static  IBookCommentDAL GetIBookCommentDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".BookCommentDAL") as IBookCommentDAL;
        }
		/// <summary>
        /// 返回一个包含BooksDAL实例的IBooksDAL接口
        /// </summary>
        /// <returns></returns>
        public static  IBooksDAL GetIBooksDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".BooksDAL") as IBooksDAL;
        }
		/// <summary>
        /// 返回一个包含CartDAL实例的ICartDAL接口
        /// </summary>
        /// <returns></returns>
        public static  ICartDAL GetICartDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".CartDAL") as ICartDAL;
        }
		/// <summary>
        /// 返回一个包含CategoriesDAL实例的ICategoriesDAL接口
        /// </summary>
        /// <returns></returns>
        public static  ICategoriesDAL GetICategoriesDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".CategoriesDAL") as ICategoriesDAL;
        }
		/// <summary>
        /// 返回一个包含CheckEmailDAL实例的ICheckEmailDAL接口
        /// </summary>
        /// <returns></returns>
        public static  ICheckEmailDAL GetICheckEmailDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".CheckEmailDAL") as ICheckEmailDAL;
        }
		/// <summary>
        /// 返回一个包含DepartmentDAL实例的IDepartmentDAL接口
        /// </summary>
        /// <returns></returns>
        public static  IDepartmentDAL GetIDepartmentDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".DepartmentDAL") as IDepartmentDAL;
        }
		/// <summary>
        /// 返回一个包含keyWordsRankDAL实例的IkeyWordsRankDAL接口
        /// </summary>
        /// <returns></returns>
        public static  IkeyWordsRankDAL GetIkeyWordsRankDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".keyWordsRankDAL") as IkeyWordsRankDAL;
        }
		/// <summary>
        /// 返回一个包含OrderBookDAL实例的IOrderBookDAL接口
        /// </summary>
        /// <returns></returns>
        public static  IOrderBookDAL GetIOrderBookDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".OrderBookDAL") as IOrderBookDAL;
        }
		/// <summary>
        /// 返回一个包含OrdersDAL实例的IOrdersDAL接口
        /// </summary>
        /// <returns></returns>
        public static  IOrdersDAL GetIOrdersDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".OrdersDAL") as IOrdersDAL;
        }
		/// <summary>
        /// 返回一个包含PublishersDAL实例的IPublishersDAL接口
        /// </summary>
        /// <returns></returns>
        public static  IPublishersDAL GetIPublishersDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".PublishersDAL") as IPublishersDAL;
        }
		/// <summary>
        /// 返回一个包含R_UserInfo_ActionInfoDAL实例的IR_UserInfo_ActionInfoDAL接口
        /// </summary>
        /// <returns></returns>
        public static  IR_UserInfo_ActionInfoDAL GetIR_UserInfo_ActionInfoDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".R_UserInfo_ActionInfoDAL") as IR_UserInfo_ActionInfoDAL;
        }
		/// <summary>
        /// 返回一个包含RoleDAL实例的IRoleDAL接口
        /// </summary>
        /// <returns></returns>
        public static  IRoleDAL GetIRoleDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".RoleDAL") as IRoleDAL;
        }
		/// <summary>
        /// 返回一个包含SearchDetailsDAL实例的ISearchDetailsDAL接口
        /// </summary>
        /// <returns></returns>
        public static  ISearchDetailsDAL GetISearchDetailsDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".SearchDetailsDAL") as ISearchDetailsDAL;
        }
		/// <summary>
        /// 返回一个包含SettingsDAL实例的ISettingsDAL接口
        /// </summary>
        /// <returns></returns>
        public static  ISettingsDAL GetISettingsDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".SettingsDAL") as ISettingsDAL;
        }
		/// <summary>
        /// 返回一个包含SysFunDAL实例的ISysFunDAL接口
        /// </summary>
        /// <returns></returns>
        public static  ISysFunDAL GetISysFunDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".SysFunDAL") as ISysFunDAL;
        }
		/// <summary>
        /// 返回一个包含UserInfoDAL实例的IUserInfoDAL接口
        /// </summary>
        /// <returns></returns>
        public static  IUserInfoDAL GetIUserInfoDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".UserInfoDAL") as IUserInfoDAL;
        }
		/// <summary>
        /// 返回一个包含UsersDAL实例的IUsersDAL接口
        /// </summary>
        /// <returns></returns>
        public static  IUsersDAL GetIUsersDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".UsersDAL") as IUsersDAL;
        }
		/// <summary>
        /// 返回一个包含UserStatesDAL实例的IUserStatesDAL接口
        /// </summary>
        /// <returns></returns>
        public static  IUserStatesDAL GetIUserStatesDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".UserStatesDAL") as IUserStatesDAL;
        }
		/// <summary>
        /// 返回一个包含VidoFileDAL实例的IVidoFileDAL接口
        /// </summary>
        /// <returns></returns>
        public static  IVidoFileDAL GetIVidoFileDALInstance()
        {
           return  CreateInstance(DalAssemblyPath, NameSpace + ".VidoFileDAL") as IVidoFileDAL;
        }
	}	
}