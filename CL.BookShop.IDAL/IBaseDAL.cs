using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.BookShop.IDAL
{
    public interface IBaseDAL<T>where T:class ,new ()
    {
        IQueryable<T> LoadEntities(System.Linq.Expressions.Expression< Func<T, bool>> whereLambda);

        IQueryable<T> LoadPageEntities<s>(int pageIndex, int pageSize, out int totalCount, Func<T, bool> whereLambda, Func<T, s> orderLambda, bool isAsc);

        T AddEntity(T entity);

        bool DeleteEntity(T entity);

        bool UpdateEntity(T entity);

        //IQueryable<T> LoadPageEntities<T1>(int pageIndex, int pageSize, out int totalCount, Func<T, bool> whereLambda, Func<T,s> orderbyLambda, bool isAsc);
    }
}
