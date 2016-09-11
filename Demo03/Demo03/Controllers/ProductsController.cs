using Demo03.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;


namespace Demo03.Controllers
{
    public class ProductsController : ODataController
    {
        
        private AppDbContext _context = new AppDbContext(); 
        
        
        // GET odata/Products => []
        [EnableQuery]
        public IQueryable GetProducts()
        {
            return _context.Products;
        }

        [EnableQuery]
        public SingleResult<Product> Get([FromUri] int key)
        {
            var result = _context.Products.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        public async Task<IHttpActionResult> Post(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return Created(product);
        }

//        public string myfunction(string x, Product y)
//        {
//            return x;
//        }
        
    }
}
