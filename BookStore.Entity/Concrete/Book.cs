using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Entity.Concrete
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public string BookName { get; set; }
        public string Summary { get; set; }
        public Author Author { get; set; }
        public DateTime PublishDate { get; set; }
        public int AmountSold { get; set; }
        public Publisher Publisher { get; set; }
        public Category Category { get; set; }
        public List<StoreBook> StoreBooks { get; set; }
    }
}
