using EShop.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Repository.Interface
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();
        Book Get(Guid? id);
        void Insert(Book entity);
        void Update(Book entity);
        void Delete(Book entity);
    }

}
