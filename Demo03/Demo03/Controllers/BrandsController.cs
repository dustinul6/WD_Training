using Demo03.Models;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.OData;

namespace Demo03.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.OData.Builder;
    using System.Web.OData.Extensions;
    using Demo03.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Brand>("Brands");
    builder.EntitySet<Product>("Products"); 
    config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BrandsController : ODataController
    {
        private AppDbContext db = new AppDbContext();

        // GET: odata/Brands
        [EnableQuery]
        public IQueryable<Brand> GetBrands()
        {
            return db.Brands;
        }

        // GET: odata/Brands(5)
        [EnableQuery]
        public SingleResult<Brand> GetBrand([FromODataUri] int key)
        {
            return SingleResult.Create(db.Brands.Where(brand => brand.Id == key));
        }

        // PUT: odata/Brands(5)
        public async Task<IHttpActionResult> Put([FromODataUri] int key, Delta<Brand> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Brand brand = await db.Brands.FindAsync(key);
            if (brand == null)
            {
                return NotFound();
            }

            patch.Put(brand);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BrandExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(brand);
        }

        // POST: odata/Brands
        public async Task<IHttpActionResult> Post(Brand brand)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Brands.Add(brand);
            await db.SaveChangesAsync();

            return Created(brand);
        }

        // PATCH: odata/Brands(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<Brand> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Brand brand = await db.Brands.FindAsync(key);
            if (brand == null)
            {
                return NotFound();
            }

            patch.Patch(brand);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BrandExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(brand);
        }

        // DELETE: odata/Brands(5)
        public async Task<IHttpActionResult> Delete([FromODataUri] int key)
        {
            Brand brand = await db.Brands.FindAsync(key);
            if (brand == null)
            {
                return NotFound();
            }

            db.Brands.Remove(brand);
            await db.SaveChangesAsync();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/Brands(5)/Products
        [EnableQuery]
        public IQueryable<Product> GetProducts([FromODataUri] int key)
        {
            return db.Brands.Where(m => m.Id == key).SelectMany(m => m.Products);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BrandExists(int key)
        {
            return db.Brands.Count(e => e.Id == key) > 0;
        }
    }
}
