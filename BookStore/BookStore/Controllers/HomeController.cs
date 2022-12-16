using BookStore.Models;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var data = list();
            return View(data);
        }
        public ViewResult AllBooks()
        {
            var data = list();
            return View(data);

        }
        public ViewResult GetOneBook()
        {
            var data = list();
            return View(data);
        }
       
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
       

        private List<BookModel> list()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Price=101,Description="This is demo book", Title="Dot Net",Author="Sourav kr"},
                new BookModel(){Id=2,Price=102,Description="This is demo book", Title="MVC",Author="Sourav kr ch"},
                new BookModel(){Id=3,Price=103,Description="This is demo book", Title="Java" ,Author="Sourav kumar"},
                new BookModel(){Id=4,Price=104,Description="This is demo book", Title="c++",Author="Sourav choudhary"}
            };

        }



    }
}
