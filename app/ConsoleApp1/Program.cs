using ConsoleDump;
using Rhetos.Configuration.Autofac;
using Rhetos.Dom.DefaultConcepts;
using Rhetos.Logging;
using Rhetos.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger.MinLevel = EventType.Info; // Use "Trace" for more details log.
            var rhetosServerPath = @"C:\Projects\Demo\dist\DemoRhetosServer";
            Directory.SetCurrentDirectory(rhetosServerPath);
            using (var container = new RhetosTestContainer(commitChanges: true)) // Use this parameter to COMMIT or ROLLBACK the data changes.
            {
                var context = container.Resolve<Common.ExecutionContext>();
                var repository = context.Repository;

                //var filter = new FilterCriteria("Title","StartsWith","m");
                //var books = repository.Bookstore.Book.Load().Dump();
                //var sobe = repository.Rezervacije.Soba.Load().Dump();
                //var query = repository.Rezervacije.Soba.Query().Select(b => new { b.Ime, b.Hotel.Ime }).Dump();
                // var books1 = repository.Bookstore.Book.Query().Select(x=>x.Author.Name).ToList().Dump("1");
                //var books2 = repository.Bookstore.Book.Query(filter).ToString().Dump("1");

                //var book = new Bookstore.Book
                //{
                //    NumberOfPages = 20,
                //    Title = "Linq"
                //};
                //repository.Bookstore.Book.Insert(book);
                var filter = new Bookstore.Pretrazivanje { MinBrojStranica = 10 };
                repository.Bookstore.Book.Query(filter).ToList().Dump();

            }
        }
    }
}
