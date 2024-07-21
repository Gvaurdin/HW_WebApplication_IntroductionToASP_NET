using HW_WebApplication_IntroductionToASP_NET.Model;
using Microsoft.AspNetCore.Mvc;

namespace HW_WebApplication_IntroductionToASP_NET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private static List<Product> products =
        [
            new Product
            {
                Id = 1,
                Title = "Car",
                Description = "Audi 100",
                Price = 500000,
                Date = new DateTime(1998,1,15)
            }
        ];

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }

        [HttpPost]
        public void CreateProduct(Product product)
        {
            products.Add(product);
        }

        [HttpPut]
        public void UpdateProduct(int id,Product newProduct)
        {
            var updatedProduct = products.First(x=> x.Id == id);

            updatedProduct.Title = newProduct.Title;
            updatedProduct.Description = newProduct.Description;
            updatedProduct.Price = newProduct.Price;
            updatedProduct.Date = newProduct.Date;
        }

        [HttpDelete]

        public void DeleteProduct(int id)
        {
            var deleteProduct = products.First(x => x.Id == id);
            products.Remove(deleteProduct);
        }
    }
}
