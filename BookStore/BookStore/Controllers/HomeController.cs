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
        public ViewResult GetOneBook(int id)
        {
            var data = getonee(id);
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
       
        private BookModel getonee(int id)
        {
            var a = list();
           return a.Where(x => x.Id == id).FirstOrDefault();
        }
        private List<BookModel> list()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Price=101,Description="This is demo book", Title="Dot Net",Author="Sourav kr",Category="Study",Language="English",PageCount=500},
                new BookModel(){Id=2,Price=102,Description="This is demo book", Title="MVC",Author="Sourav kr ch",Category="Study",Language="English",PageCount=400},
                new BookModel(){Id=3,Price=103,Description="This is demo book", Title="Java" ,Author="Sourav kumar",Category="Study",Language="English",PageCount=30},
                new BookModel(){Id=4,Price=104,Description="This is demo book", Title="c++",Author="Sourav choudhary",Category="Study",Language="English",PageCount=5120}
            };

        }



    }
}
