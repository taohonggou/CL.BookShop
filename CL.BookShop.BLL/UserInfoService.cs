using CL.BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.BookShop.BLL
{
    public class UserInfoService : BaseService<UserInfo>
    {
        public override void SetCurrentDAL()
        {
            CurrentDAL = this.DbSession.UserInfoDAL;
        }
    }
}
