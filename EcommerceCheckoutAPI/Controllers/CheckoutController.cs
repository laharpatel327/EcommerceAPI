using EcommerceCheckoutAPI.Models;
using EcommerceCheckoutAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Schema;

namespace EcommerceCheckoutAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CheckoutController : Controller
    {
        private readonly ICatalogService _catalogService;
        public CheckoutController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        [HttpGet]
        public ActionResult<CatalogResponse> GetCheckoutPrice([FromQuery] List<string> watches)
        {
            var totalPrice = _catalogService.GetCheckoutPrice(watches);
            var catalogResponse = new CatalogResponse
            {
                Price = totalPrice
            };
            return catalogResponse;
        }
    }
}