using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;

namespace CL.BookShop.IDAL
{
   public interface IDBSession
    {
        IUserInfoDAL UserInfoDAL { get; set; }

        int ExecuteSql(string sql, params SqlParameter[] param);

        DbContext Db
        {
            get;
        }

        int SaveChanges();
    }
}
