using CL.BookShop.IBLL;
using CL.BookShop.Model;
using System.Collections.Generic;

namespace CL.BookShop.BLL
{
    public partial class UserInfoService : BaseService<UserInfo>,IUserInfoService
    {
        /// <summary>
        /// 批量删除用户数据
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool DeleteEntities(List<int> list)
        {
            var users = this.DbSession.UserInfoDAL.LoadEntities(u => list.Contains(u.ID));
            foreach (UserInfo user in users)
            {
                this.DbSession.UserInfoDAL.DeleteEntity(user);
            }
            return  this.DbSession.SaveChanges()>0;
        }

        
    }
}
