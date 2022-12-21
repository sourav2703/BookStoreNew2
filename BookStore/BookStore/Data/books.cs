using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public class  books
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public string Language { get; set; }
        public string Category { get; set; }

        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

    }
}
