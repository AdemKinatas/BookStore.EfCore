using BookStore.Entity.Concrete;
using Core.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.DataAccess.Abstract
{
    public interface IStoreDal : IEntityRepository<Store>
    {
    }
}
