using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Entity.Concrete
{
    public class Store : IEntity
    {
        public int Id { get; set; }
        public string ShopName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<StoreBook> StoreBooks { get; set; }
    }
}
