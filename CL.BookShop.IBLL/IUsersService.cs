using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CL.BookShop.Model;

namespace CL.BookShop.IBLL
{
   public partial interface IUsersService
    {
        Users AddEntity(Users user, out string msg);
    }
}
