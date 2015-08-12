using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL.BookShop.IDAL;
using CL.BookShop.Model;

namespace CL.BookShop.DAL
{
    public class UserInfoDAL : BaseDAL<UserInfo>, IUserInfoDAL
    {
        //这里写自己特有的方法
        //public IQueryable<UserInfo> LoadPageEntities<T1>(int pageIndex, int pageSize, out int totalCount, Func<UserInfo, bool> whereLambda, Func<UserInfo, s> orderbyLambda, bool isAsc)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
