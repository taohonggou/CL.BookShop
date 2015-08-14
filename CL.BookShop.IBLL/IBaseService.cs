﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.BookShop.IBLL
{
    public interface IBaseService<T> where T :class,new()
    {
        IDAL.IDBSession DbSession { get; }
        IDAL.IBaseDAL<T> CurrentDAL { get; set; }
        IQueryable<T> LoadEntities(System.Linq.Expressions.Expression< Func<T, bool>> whereLambda);
        IQueryable<T> LoadPageEntities<s>(int pageIndex, int pageSize, out int totalCount, System.Linq.Expressions.Expression<Func<T, bool>> whereLambda, System.Linq.Expressions.Expression<Func<T, s>> orderbyLambda, bool isAsc);
        T AddEntity(T entity);
        bool DeleteEntity(T entity);
        bool UpdateEntity(T entity);



    }
}
