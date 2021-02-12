using BookStore.DataAccess.Abstract;
using BookStore.DataAccess.Concrete.EntityFramework.Context;
using BookStore.Entity.Concrete;
using Core.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.DataAccess.Concrete.EntityFramework
{
    public class EfPublisherDal : EfEntityRepositoryBase<Publisher, BookStoreContext>, IPublisherDal
    {
    }
}
