using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using CL.BookShop.Model;
namespace CL.BookShop.DAL
{
    /// <summary>
    /// 负责创建EF上下文，保证线程内唯一，再一次请求内只创建一次
    /// </summary>
   public class DbContextFactory
    {
        
        /// <summary>
        /// 保证DbContext在线程内唯一
        /// </summary>
        /// <returns></returns>
        public static DbContext GetCurrentDbContext()
        {
            DbContext dbContext = (DbContext)CallContext.GetData("dbContext");
            if (dbContext==null)
            {
                dbContext = new book_shop3Entities();
                CallContext.SetData("dbContext", dbContext);
                
            }
            return dbContext;
        }
    }
}
