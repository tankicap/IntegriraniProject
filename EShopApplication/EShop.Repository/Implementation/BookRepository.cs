using EShop.Domain.Domain;
using EShop.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Repository.Implementation
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<Book> entities;

        public BookRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<Book>();
        }
        public void Delete(Book entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }

        public Book Get(Guid? id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }

        public IEnumerable<Book> GetAll()
        {
            return context.Books
           .Include(b => b.Author)    
           .Include(b => b.Publisher);
        }

        public void Insert(Book entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(Book entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }
    }
}
