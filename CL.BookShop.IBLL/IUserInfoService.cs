using CL.BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.BookShop.IBLL
{
    public  interface IUserInfoService:IBaseService<UserInfo>
    {
        bool DeleteEntities(List<int> list);
    }
}
