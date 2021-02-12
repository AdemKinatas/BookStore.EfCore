using BookStore.DataAccess.Abstract;
using BookStore.Entity.Concrete;
using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StoreManager : IStoreService
    {
        IStoreDal _storeDal;

        public StoreManager(IStoreDal storeDal)
        {
            _storeDal = storeDal;
        }

        public void Add(Store store)
        {
            _storeDal.Add(store);
        }

        public void Delete(Store store)
        {
            _storeDal.Delete(store);
        }

        public Store Get(Expression<Func<Store, bool>> filter)
        {
            return _storeDal.Get(filter);
        }

        public List<Store> GetList(Expression<Func<Store, bool>> filter = null)
        {
            return _storeDal.GetList(filter);
        }

        public void Update(Store store)
        {
            _storeDal.Update(store);
        }
    }
}
