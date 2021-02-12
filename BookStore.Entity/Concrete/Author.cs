using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Entity.Concrete
{
    public class Author : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Biography { get; set; }
        public List<Book> Books { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
