using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace University_App.Models.Generics
{
    public class Repository<T>: IRepository<T> where T: class, IEntity
    {
        protected Table<T> DataTable;
        public Repository(DataContext dataContext);
        
        #region IRepository<T> Members
        public void Insert(T entity)
        {
            DataTable.InsertOnSubmit(entity);
        }
        public void Delete(T entity)
        {
            DataTable.DeleteOnSubmit(entity);
        }
        public IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate)
        {
            return DataTable.Where(predicate);
        }
        public IQueryable<T> GetAll()
        {
            return DataTable;
        }
        public T GetById(int id)
        {
            return DataTable.Single(e => e.Id.Equals(id));
        }
        #endregion
    }
}
