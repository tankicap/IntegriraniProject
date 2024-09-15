using EShop.Repository;
using EShop.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Eshop.Web.Controllers
{
    public class BookPartner : Controller
    {
        private readonly IBookPartnerService _bookPartnerService;

        public BookPartner(IBookPartnerService bookPartnerService)
        {
            _bookPartnerService = bookPartnerService;

        }
        public IActionResult Index()
        {
            var book=_bookPartnerService.GetBooks();
            return View(book);
        }
    }
}
