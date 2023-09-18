using EcommerceCheckoutAPI.Controllers;
using EcommerceCheckoutAPI.Models;
using EcommerceCheckoutAPI.Repositories;
using EcommerceCheckoutAPI.Services;
using Microsoft.AspNetCore.Mvc;
using webapitests;

namespace webapitests
{
    public class CheckoutAPIWebApiTest
    {
        private readonly ICatalogService _service;
        private readonly ICatalogRepository _catalogRepository;
        private readonly CatalogContext _context;
        private readonly CheckoutController _checkoutController;

        public CheckoutAPIWebApiTest()
        {
            _context = new CatalogContext();
            _catalogRepository = new CatalogRepository(_context);
            _service = new CatalogService(_catalogRepository);  
            _checkoutController = new CheckoutController(_service);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsCorrectPrice()
        {
            var _watches = new List<string>()
            {
                "Rolex",
                "Rolex",
                "Rolex",
                "Michael Kors",
                "Swatch"
            };
            // Act
            var result = _service.GetCheckoutPrice(_watches);
            // Assert
            Assert.IsType<double>(result);
            Assert.Equal(330, result);
        }
    }
}
