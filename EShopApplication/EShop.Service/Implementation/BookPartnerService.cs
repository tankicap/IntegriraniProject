using Dapper;
using EShop.Domain.Domain;
using EShop.Service.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Implementation
{
    public class BookPartnerService : IBookPartnerService
    {
        private readonly string _connectionString;

        public BookPartnerService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("Partner") ?? throw new System.ArgumentNullException(nameof(configuration));
        }

        public IEnumerable<Book> GetBooks()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var books = connection.Query("SELECT * FROM Books");

                List<Book> localBooks = new List<Book>();

                foreach (var book in books)
                {
                    var kniga = new Book
                    {
                        Id = book.Id,
                        BookName = "Book Title: " + book.Title,
                        BookDescription ="Description: " + book.Description,
                        Price =book.Price
                        
                    };
                    localBooks.Add(kniga);
                }

                return localBooks;
            }
        }

       
    }
}
