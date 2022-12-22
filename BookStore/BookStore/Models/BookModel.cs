﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Controllers;

namespace BookStore.Models
{
    public class BookModel
    {  
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }
        [Required]
        public string Author { get; set; }
        public int PageCount { get; set; }
        public string Language { get; set; }
        public string Category { get; set; }
    }
}
