using CL.BookShop.Model;
using System.Collections.Generic;

namespace CL.BookShop.IBLL
{
    public partial  interface IUserInfoService:IBaseService<UserInfo>
    {
        bool DeleteEntities(List<int> list);
    }
}
