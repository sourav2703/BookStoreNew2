using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Controllers;

namespace BookStore.Models
{
    public class BookModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }
    }
}
