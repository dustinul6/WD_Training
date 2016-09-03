using Demo03.Models;
using System.Web.Http;


namespace Demo03.Controllers
{
    public class ProductsController : ApiController
    {
        
        private AppDbContext _context = new AppDbContext(); 
        
        
        // GET api/Products => []
        public IHttpActionResult GetAllProducts()
        {
            var productlist = _context.Products;
            return Ok(productlist);
        }

//        public string myfunction(string x, Product y)
//        {
//            return x;
//        }
        
    }
}
