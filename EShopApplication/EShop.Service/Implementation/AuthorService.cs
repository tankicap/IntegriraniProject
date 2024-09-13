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
    public class AuthorService : IAuthorService
    {
        private readonly IRepository<Author> _authorRepository;

        public AuthorService(IRepository<Author> authorRepository)
        {
            _authorRepository = authorRepository;
            
        }

        public void CreateNewAuthor(Author p)
        {
            _authorRepository.Insert(p);
        }

        public void DeleteAuthor(Guid id)
        {
            var author = _authorRepository.Get(id);
            _authorRepository.Delete(author);
        }

        public List<Author> GetAllAuthors()
        {
            return _authorRepository.GetAll().ToList();
        }

        public Author GetDetailsForAuthor(Guid? id)
        {
            var author = _authorRepository.Get(id);
            return author;
        }

        public void UpdateExistingAuthor(Author p)
        {
            _authorRepository.Update(p);
        }
    }
}
