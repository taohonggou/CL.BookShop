using CL.BookShop.IDAL;
using CL.BookShop.Model;

namespace CL.BookShop.DAL
{
    public partial class UserInfoDAL : BaseDAL<UserInfo>, IUserInfoDAL
    {
        //这里写自己特有的方法
        //public IQueryable<UserInfo> LoadPageEntities<T1>(int pageIndex, int pageSize, out int totalCount, Func<UserInfo, bool> whereLambda, Func<UserInfo, s> orderbyLambda, bool isAsc)
        //{
        //    throw new NotImplementedException();
        //}
        //public IQueryable<UserInfo> LoadEntities(Expression<Func<UserInfo, bool>> whereLambda)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
