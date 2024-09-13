using EShop.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Interface
{
    public interface IAuthorService
    {
        List<Author> GetAllAuthors();
        Author GetDetailsForAuthor(Guid? id);
        void CreateNewAuthor(Author p);
        void UpdateExistingAuthor(Author p);
        void DeleteAuthor(Guid id);
    }
}
