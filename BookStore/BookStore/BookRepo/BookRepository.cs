using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.BookRepo
{
    public class BookRepository
    {
        private readonly BookStoreContext _context = null;

        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }
        //BookModel
        public async Task<List<books>>  AllBooks()
        {
           // var books = new List<BookModel>();
            var data = await _context.books.ToListAsync();
            if (data!=null)
            {
                //?.Any() == true
                //foreach (var book in data)
                //{

                //    books.Add(new BookModel()
                //    {
                //        Author = book.Author,
                //        Category=book.Category,
                //        Description=book.Description,
                //        Language=book.Language,
                //        PageCount=book.PageCount,
                //        Price=book.Price,
                //        Title=book.Title
                //    });

                //}
                return data;
            }
            return null;

            // return books;
        }


        public List<books> Index_Page()
        {
            var data = _context.books.ToList();
            if (data != null)
            {
                return data;

            }
            return null;
        }


        public books getonee(int id)
        {
            var a = _context.books.ToList();
            return a.Where(x => x.Id == id).FirstOrDefault();
        }
        public async Task<int> AddNewBook(BookModel model)
        {
            var newBook = new books()
            {
                Title = model.Title,
                Author = model.Author,
                Description = model.Description,
                CreatedOn=DateTime.UtcNow,
                UpdatedOn=DateTime.UtcNow,
                PageCount=model.PageCount
            };
            

            await _context.books.AddAsync(newBook);
           
            await _context.SaveChangesAsync();
            return newBook.Id;
        }
       

        public List<BookModel> list()
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
