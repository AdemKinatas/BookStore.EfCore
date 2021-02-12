using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Entity.Concrete
{
    public class Category : IEntity
    {
        public Category()
        {
            IsPopular = false;
            IsActive = true;
            AddedAt = DateTime.Now;
        }
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int? ParentId { get; set; }
        public virtual Category Parent { get; set; }
        public virtual List<Category> Children { get; set; }
        public bool IsPopular { get; set; }
        public DateTime AddedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
