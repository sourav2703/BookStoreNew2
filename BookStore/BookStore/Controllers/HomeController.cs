using BookStore.Models;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using BookStore.Data;
using BookStore.BookRepo;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        public readonly BookRepository _bookRepository = null;
        public HomeController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }


        //.................ViewData Attribute for setting title........................
        [ViewData]
        public string Title { get; set; }

        //.................ViewData Attribute for setting title........................

        public ViewResult Index()
        {
            Title ="Home";
            //.................ViewBag.............................
            dynamic dataa = new ExpandoObject();
            dataa.id = 1;
            dataa.name = "Choudhary";
            ViewBag.data = dataa;
            ViewBag.Title = "Sourav";
            ViewBag.obj = new BookModel() { Category = "viewbag_category" , Language="Hindi" };
            //.....................................................

            //..................ViewData................
            dynamic d = new ExpandoObject();
            d.naam = "sourav";
            d.baapkanaam = "awadhesh";
            ViewData["Title"] = "Book Store";
            ViewData["an"] = d;
            ViewData["Obj"] = new BookModel() { Language = "bhojpuri" };

            //..........................................

            //...................Title.......................//

            
            var data = _bookRepository.Index_Page();
            return View(data);
        }
        public async Task<ViewResult> AllBooks()
        {
            var book = await _bookRepository.AllBooks();
           
            return View(book);
        }
       // [Route("hello")]
        public IActionResult GetOneBook(int id)
        {
            var a = _bookRepository.getonee(id);
           
            //var data = getonee(id);
            //Title = "AllBooks";
            return View(a);


        }
       

        public ViewResult AboutUs()
        {
            Title = "AboutUs";

            return View();
        }
        public ViewResult ContactUs()
        {
            Title = "Contact Us";

            return View();
        }
        public ViewResult AddBooks( bool IsSuccess = false, int ShowingBookByID=0)
        {
            ViewBag.IsSuccess = IsSuccess;
            ViewBag.ShowingBookByID = ShowingBookByID;
            Title = "AddBooks";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBooks(BookModel bookModels )
        {
            int Id= await _bookRepository.AddNewBook(bookModels);
            //Title = "AddBooks";
            if (Id > 0)
            {
                
                return RedirectToAction(nameof(AddBooks) ,  new { IsSuccess = true, ShowingBookByID = Id } );
            }
            return View();
        }
        //------------------------------------------------------------------------

       
       
       
      



    }
}
