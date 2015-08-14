using System.Data.SqlClient;
using System.Data.Entity;

namespace CL.BookShop.IDAL
{
    public partial interface IDBSession
    {
       // IUserInfoDAL UserInfoDAL { get; set; }

        int ExecuteSql(string sql, params SqlParameter[] param);

        DbContext Db { get; }
        

        int SaveChanges();
    }
}
