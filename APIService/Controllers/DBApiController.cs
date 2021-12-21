using APIService.Models;
using Microsoft.AspNetCore.Mvc;
namespace APIService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DBApiController : ControllerBase
    {
        ProductCatalogContext productCatalogContext;

        public DBApiController(ProductCatalogContext ctx)
        {
            productCatalogContext = ctx;
        }
        [HttpGet("{top}/{skip}")]
        public async  Task<IActionResult> Get(int? top = 0, int? skip=0)
        {
            List<Product> products = new List<Product>();
            if (top == 0 && skip == 0)
            {
                products = productCatalogContext.Products.ToList();
            }

            if (top > 0 && skip == 0)
            {
                products = productCatalogContext.Products
                                         .Take(Convert.ToInt32(top))
                           .ToList<Product>();
            }
            if(top >0  && skip > 0 )
            {
                products = productCatalogContext.Products
                                         .Skip(Convert.ToInt32(skip))
                                         .Take(Convert.ToInt32(top))
                           .ToList<Product>();
            }
            
           return Ok(products);
        }
    }
}
