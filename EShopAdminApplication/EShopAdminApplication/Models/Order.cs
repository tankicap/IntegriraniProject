namespace EShopAdminApplication.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string userId { get; set; }
        public EShopApplicationUser Owner { get; set; }
        public IEnumerable<BookInOrder> BooksInOrder { get; set; }
    }
}
