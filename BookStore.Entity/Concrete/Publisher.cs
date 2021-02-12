using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Entity.Concrete
{
    public class Publisher : IEntity
    {
        public int Id { get; set; }
        public string PublisherName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public List<Book> Books { get; set; }
    }
}
