using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Controllers;

namespace BookStore.Models
{
    public class BookModel
    {  
        [Required(ErrorMessage ="Please Enter Title")]
        [StringLength(100,ErrorMessage ="Max length is 100")]
        [MinLength(10,ErrorMessage ="Min Length is 10")]
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter Author Name")]
        public string Author { get; set; }
        [Required(ErrorMessage ="Please Enter Total Page Count")]
        [Display(Name ="Total Page")]
        public int PageCount { get; set; }
        public string Language { get; set; }
        public string Category { get; set; }
        [DataType(DataType.Date)]
        public string MyField { get; set; }
    }
}
