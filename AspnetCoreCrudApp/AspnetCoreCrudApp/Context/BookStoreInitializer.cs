using AspnetCoreCrudApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCoreCrudApp.Context
{

    public static class BookStoreInitializer
    {
        public static void Initialize(BookStoreContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Books.Any())
            {
                return;   // DB has been seeded
            }

            List<Book> bookList = new List<Book>()
            {
                new Book()
                {
                    Title = "C# Dünyasına Merhaba: Asp.net",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur finibus urna in suscipit bibendum. Pellentesque ut.",
                    Price=100,
                    StockQuantity = 50,
                    Type="Web Programlama",
                    PublishDate = DateTime.Now,
                    Category = context.Categories.Where(i=>i.Id == 1).FirstOrDefault()

                },
                 new Book()
                {
                    Title = "Asp.net Web Form'a Giriş",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur finibus urna in suscipit bibendum. Pellentesque ut.",
                    Price=200,
                    StockQuantity = 70,
                    Type="Web Programlama",
                    PublishDate = DateTime.Now,
                    Category = context.Categories.Where(i=>i.Id == 2).FirstOrDefault()


                },
                  new Book()
                {
                    Title = "Asp.net MVC ile Yönetim Panelli Site Yapımı",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur finibus urna in suscipit bibendum. Pellentesque ut.",
                    Price=110,
                    StockQuantity = 25,
                    Type="Web Programlama",
                    PublishDate = DateTime.Now,
                    Category = context.Categories.Where(i=>i.Id == 3).FirstOrDefault()


                },
                   new Book()
                {
                    Title = "Asp.net MVC ile Katmanlı Mimari",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur finibus urna in suscipit bibendum. Pellentesque ut.",
                    Price=110,
                    StockQuantity = 25,
                    Type="Web Programlama",
                    PublishDate = DateTime.Now,
                    Category = context.Categories.Where(i=>i.Id == 3).FirstOrDefault()


                },
                     new Book()
                {
                    Title = "Asp.net MVC ile Yönetim Panelli Site Yapımı 2",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur finibus urna in suscipit bibendum. Pellentesque ut.",
                    Price=110,
                    StockQuantity = 25,
                    Type="Web Programlama",
                    PublishDate = DateTime.Now,
                    Category = context.Categories.Where(i=>i.Id == 3).FirstOrDefault()


                },
                   new Book()
                {
                    Title = "A'dan Z'ye Python",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur finibus urna in suscipit bibendum. Pellentesque ut.",
                    Price=120,
                    StockQuantity = 80,
                    Type="Web Programlama",
                    PublishDate = DateTime.Now,
                    Category = context.Categories.Where(i=>i.Id == 4).FirstOrDefault()


                },
                   new Book()
                {
                    Title = "Java ile Mobil Uygulama",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur finibus urna in suscipit bibendum. Pellentesque ut.",
                    Price=120,
                    StockQuantity = 80,
                    Type="Web Programlama",
                    PublishDate = DateTime.Now,
                    Category = context.Categories.Where(i=>i.Id == 5).FirstOrDefault()


                },   new Book()
                {
                    Title = "Java ile Web Uygulamaları",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur finibus urna in suscipit bibendum. Pellentesque ut.",
                    Price=120,
                    StockQuantity = 80,
                    Type="Web Programlama",
                    PublishDate = DateTime.Now,
                    Category = context.Categories.Where(i=>i.Id == 5).FirstOrDefault()


                }
            };
            foreach (var book in bookList)
            {
                context.Books.Add(book);
            }
            context.SaveChanges();
        }
    }
}
