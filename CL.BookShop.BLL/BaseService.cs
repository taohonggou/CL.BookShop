using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.BookShop.BLL
{
    public abstract class BaseService<T> where T : class, new()
    {

        public IDAL.IDBSession DbSession
        {
            get { return DALFactory.DBSessionFactory.CreateDbSession(); }
        }

        public IDAL.IBaseDAL<T> CurrentDAL { get; set; }//表示当前数据操作类的实例

        public abstract void SetCurrentDAL();

        public BaseService()
        {
            SetCurrentDAL();//保证子类重写父类中的抽象方法
        }

        public IQueryable<T> LoadEntities(System.Linq.Expressions.Expression<Func<T, bool>>  whereLambda)
        {
            //this.DbSession.u
            return this.CurrentDAL.LoadEntities(whereLambda);
        }

        public IQueryable<T> LoadPageEntities<s>(int pageIndex, int pageSize, out int totalCount, System.Linq.Expressions.Expression<Func<T, bool>> whereLambda, System.Linq.Expressions.Expression<Func<T, s>> orderbyLambda, bool isAsc)
        {
            return this.CurrentDAL.LoadPageEntities<s>(pageIndex, pageSize, out totalCount, whereLambda, orderbyLambda, isAsc);
        }

        public T AddEntity(T entity)
        {
            this.CurrentDAL.AddEntity(entity);
            this.DbSession.SaveChanges();
            return entity;
        }

        public bool DeleteEntity(T entity)
        {
            this.CurrentDAL.DeleteEntity(entity);
            return this.DbSession.SaveChanges()>0;

        }

        public bool UpdateEntity(T entity)
        {
            this.CurrentDAL.UpdateEntity(entity);
            return this.DbSession.SaveChanges() > 0;
        }
        
    }
}
