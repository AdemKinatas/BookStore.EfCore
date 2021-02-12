using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Entity.Concrete
{
    public class StoreBook:IEntity
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
    }
}
