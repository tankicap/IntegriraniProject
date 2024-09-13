using EShop.Domain.Domain;
using EShop.Repository.Interface;
using EShop.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Implementation
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IRepository<BookInShoppingCart> _bookInShoppingCartRepository;
        private readonly IUserRepository _userRepository;

        public BookService (IBookRepository bookRepository, IRepository<BookInShoppingCart> bookInShoppingCartRepository, IUserRepository userRepository)
        {
            _bookRepository = bookRepository;
            _bookInShoppingCartRepository = bookInShoppingCartRepository;
            _userRepository = userRepository;
        }

        public void CreateNewBook(Book p)
        {
            _bookRepository.Insert(p);
        }

        public void DeleteBook(Guid id)
        {
            var book = _bookRepository.Get(id);
            _bookRepository.Delete(book);
        }

        public List<Book> GetAllBooks()
        {
            return _bookRepository.GetAll().ToList();
        }

        public Book GetDetailsForBook(Guid? id)
        {
            var book = _bookRepository.Get(id);
            return book;
        }

        public void UpdateExistingBook(Book p)
        {
            _bookRepository.Update(p);
        }
    }
}
