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
        public ViewResult GetAllBooks()
        {
            var data = list();
            return View(data);
        }
        public ViewResult Index()
        {
            return View();
        }

        private List<BookModel> list()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Price=101,Description="This is demo book", Title="Dot Net"},
                new BookModel(){Id=2,Price=102,Description="This is demo book", Title="MVC"},
                new BookModel(){Id=3,Price=103,Description="This is demo book", Title="Java"},
                new BookModel(){Id=4,Price=104,Description="This is demo book", Title="c++"}
            };

        }



    }
}
