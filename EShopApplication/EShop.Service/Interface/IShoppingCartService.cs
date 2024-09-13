using EShop.Domain.Domain;
using EShop.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Interface
{
    public interface IShoppingCartService
    {
        ShoppingCartDto getShoppingCartInfo(string userId);
        bool deleteBookFromShoppingCart(string userId, Guid bookId);
        bool order(string userId);
        bool AddToShoppingConfirmed(BookInShoppingCart model, string userId);
    }
}
