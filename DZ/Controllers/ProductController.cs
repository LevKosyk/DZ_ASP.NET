using DZ.Models;
using DZ.Service;
using Microsoft.AspNetCore.Mvc;

namespace DZ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IServiceProducts? _serviceProducts;
        public ProductController(IServiceProducts? serviceProducts)
        {
            _serviceProducts = serviceProducts;
        }
        [HttpGet]
        public JsonResult Get() => Json(_serviceProducts.GetProducts().ToList());

        [HttpGet("{id}")]
        public JsonResult GetUserById(int id) => Json(_serviceProducts.GetProductById(id));
        [HttpPost]
        public JsonResult PostUser(Product product) => Json(_serviceProducts.CreateProduct(product));
        [HttpPut]
        public JsonResult UpdateProduct(Product product)
        {
            _serviceProducts.UpdateProduct(product);
            return Json(new { success = true });
        }

        [HttpDelete("{id}")]
        public void DeleteUser(int id) => _serviceProducts.DeleteProduct(id);
    }
}
