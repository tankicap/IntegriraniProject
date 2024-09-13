namespace EShopAdminApplication.Models
{
    public class ShoppingCart
    {
        public string? OwnerId { get; set; }
        public EShopApplicationUser? Owner { get; set; }
        public virtual ICollection<BookInShoppingCart>? BookInShoppingCarts { get; set; }
    }
}
