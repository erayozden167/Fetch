using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        static private readonly List<Product> _products = new List<Product>();
        [HttpGet]
        public List<Product> ProductList()
        {
            return _products;
        }
        [HttpGet("{id}")]
        public Product GetProduct(int id)
        {
            Product? item = _products.Find(x => x.Id == id);
                return item;
        }
        [HttpPost]
        public void CreateProduct(Product item)
        {
            _products.Add(item);
        }
        [HttpPut("{id}")]
        public void UpdateProduct(int id,Product item)
        {
            Product? x = _products.Find(x => x.Id == id);
            if (x != null)
            {
                x.Name = item.Name;
                x.Price = item.Price;
                x.Category = item.Category;
            }
        }
        [HttpDelete("{id}")]
        public void DelProduct(int id)
        {
            Product? item = _products.Find(x => x.Id == id);
            if (item == null)
            {
                return;
            }
            _products.Remove(item);
        }
    }
}
