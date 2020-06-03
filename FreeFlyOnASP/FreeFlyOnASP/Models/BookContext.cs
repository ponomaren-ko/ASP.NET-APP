using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FreeFlyOnASP.Models
{
    public class BookContext: DbContext
        
    {
        public DbSet<Book> Books  { get; set; }
        public DbSet<Order> Orders  { get; set; }
        public DbSet<Client> Clients { get; set; }
    }

    class BookDbInitializer: DropCreateDatabaseAlways<BookContext>
    {

        public override void InitializeDatabase(BookContext context)
        {
            context.Books.Add(new Book { Id = 0, Name = "Book1", Author = "Author1", Price = 25.00, Year = 2000});;
            context.Books.Add(new Book { Id = 1, Name = "Book2", Author = "Author2", Price = 25.00, Year = 2000});;
            context.Books.Add(new Book { Id = 2, Name = "Book3", Author = "Author3", Price = 25.00, Year = 2000});;


            context.Clients.Add(new Client 
            {Id = 1, 
            Name = "Bogdan",
            Surname = "Ponomarenko", 
            Email = "pononomarenko@gmail.conm", 
            Adress = "Kyiw", BirthDate = new DateTime(2000, 8, 24) , 
            Login = "login123", Password = "password123" , 
            Orders = new List<Order>()});

            base.InitializeDatabase(context);
        }
    }
}