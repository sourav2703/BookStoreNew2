using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public class BookStoreContext :  DbContext
    {
        //DbContext class is created here
        //public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        //{

        //}
        //Entityclass is created here
       

        //Overrided configure method created here
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //Connection string is passed here
            optionsBuilder.UseSqlServer("Server=sourav;Database=BookStore;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<books> books { get; set; }
        //Now we have to tell our app that we are using DBContext class. go to startUP then set services.AddDbContext();
    }
}
