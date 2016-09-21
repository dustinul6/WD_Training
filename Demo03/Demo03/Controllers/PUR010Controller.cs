using ModelCollections.Models;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;

namespace Demo03.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.OData.Builder;
    using System.Web.OData.Extensions;
    using ModelCollections.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<PUR010>("PUR010");
    config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class PUR010Controller : ODataController
    {
        private NanfongContext db = new NanfongContext();

        // GET: odata/PUR010
        [EnableQuery]
        public IQueryable<PUR010> GetPUR010()
        {
            return db.PUR010;
        }

        // GET: odata/PUR010(5)
        [EnableQuery]
        public SingleResult<PUR010> GetPUR010([FromODataUri] string key)
        {
            return SingleResult.Create(db.PUR010.Where(pUR010 => pUR010.CUST_NO == key));
        }

        // PUT: odata/PUR010(5)
        public async Task<IHttpActionResult> Put([FromODataUri] string key, Delta<PUR010> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            PUR010 pUR010 = await db.PUR010.FindAsync(key);
            if (pUR010 == null)
            {
                return NotFound();
            }

            patch.Put(pUR010);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PUR010Exists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(pUR010);
        }

        // POST: odata/PUR010
        public async Task<IHttpActionResult> Post(PUR010 pUR010)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PUR010.Add(pUR010);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PUR010Exists(pUR010.CUST_NO))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Created(pUR010);
        }

        // PATCH: odata/PUR010(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] string key, Delta<PUR010> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            PUR010 pUR010 = await db.PUR010.FindAsync(key);
            if (pUR010 == null)
            {
                return NotFound();
            }

            patch.Patch(pUR010);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PUR010Exists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(pUR010);
        }

        // DELETE: odata/PUR010(5)
        public async Task<IHttpActionResult> Delete([FromODataUri] string key)
        {
            PUR010 pUR010 = await db.PUR010.FindAsync(key);
            if (pUR010 == null)
            {
                return NotFound();
            }

            db.PUR010.Remove(pUR010);
            await db.SaveChangesAsync();

            return StatusCode(HttpStatusCode.NoContent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PUR010Exists(string key)
        {
            return db.PUR010.Count(e => e.CUST_NO == key) > 0;
        }
    }
}
