using Entity_Framework.Contexts;
using Entity_Framework.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Create a Console using EF Core CONVENTIONS ONLY Use Sql Server as the database provider

            //1. Create a Console Application using Entity Framework Core
            //2. Use EF Core CONVENTIONS ONLY 
            //3. Use Sql Server as the database provider

            #endregion

            #region 4. Identify and create the necessary entities from the case study

            //4. Identify and create the necessary entities from the case study

            #endregion

            #region 5. Create an appropriate DbContext class

            //5. Create an appropriate DbContext class

            #endregion

            #region 6. Demonstrate that the database is created correctly

            //6. Demonstrate that the database is created correctly

            //using var context = new AppDbContext();



            //Console.WriteLine($"Database exists: {context.Database.CanConnect()}");



            //var author = new Author
            //{
            //    FirstName = "George",
            //    LastName = "Orwell",
            //    Email = "orwell@example.com",
            //    Biography = "English novelist and essayist.",
            //    DateOfBirth = new DateTime(1903, 6, 25)
            //};

            //var category = new Category
            //{
            //    Name = "Fiction",
            //    Description = "Novels and short stories",
            //    IsActive = true
            //};

            //context.Books.Add(new Book
            //{
            //    Title = "1984",
            //    ISBN = "9780451524935",
            //    Price = 12.99m,
            //    NumberOfPages = 328,
            //    PublishedYear = 1949,
            //    IsInStock = true,
            //    Author = author,
            //    Category = category
            //});

            //context.SaveChanges();


            //var books = context.Books.Include(b => b.Author)
            //                         .Include(b => b.Category)
            //                         .ToList();

            //foreach (var b in books)
            //{
            //    Console.WriteLine($"{b.Title} ({b.PublishedYear}) by {b.Author.FirstName} {b.Author.LastName} " +
            //                      $"| {b.Category.Name} | ${b.Price} | In stock: {b.IsInStock}");
            //}

            #endregion

        }
    }
}
