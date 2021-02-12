using Core.DataAccess.Abstract;
using BookStore.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.DataAccess.Abstract
{
    public interface IAuthorDal : IEntityRepository<Author>
    {
    }
}
