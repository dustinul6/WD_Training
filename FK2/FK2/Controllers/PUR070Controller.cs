using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.ModelBinding;
using System.Web.OData;
using System.Web.OData.Query;
using System.Web.OData.Routing;
using ModelCollections.Models;

namespace FK2.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.OData.Builder;
    using System.Web.OData.Extensions;
    using ModelCollections.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<PUR070>("PUR070");
    config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class PUR070Controller : ODataController
    {
        private Model1 db = new Model1();

        // GET: odata/PUR070
        [EnableQuery]
        public IQueryable<PUR070> GetPUR070()
        {
            return db.PUR070;
        }

        // GET: odata/PUR070(5)
        [EnableQuery]
        public SingleResult<PUR070> GetPUR070([FromODataUri] string key)
        {
            return SingleResult.Create(db.PUR070.Where(pUR070 => pUR070.PUR07_NO == key));
        }

        // PUT: odata/PUR070(5)
        public async Task<IHttpActionResult> Put([FromODataUri] string key, Delta<PUR070> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            PUR070 pUR070 = await db.PUR070.FindAsync(key);
            if (pUR070 == null)
            {
                return NotFound();
            }

            patch.Put(pUR070);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PUR070Exists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(pUR070);
        }

        // POST: odata/PUR070
        public async Task<IHttpActionResult> Post(PUR070 pUR070)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PUR070.Add(pUR070);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PUR070Exists(pUR070.PUR07_NO))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Created(pUR070);
        }

        // PATCH: odata/PUR070(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] string key, Delta<PUR070> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            PUR070 pUR070 = await db.PUR070.FindAsync(key);
            if (pUR070 == null)
            {
                return NotFound();
            }

            patch.Patch(pUR070);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PUR070Exists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(pUR070);
        }

        // DELETE: odata/PUR070(5)
        public async Task<IHttpActionResult> Delete([FromODataUri] string key)
        {
            PUR070 pUR070 = await db.PUR070.FindAsync(key);
            if (pUR070 == null)
            {
                return NotFound();
            }

            db.PUR070.Remove(pUR070);
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

        private bool PUR070Exists(string key)
        {
            return db.PUR070.Count(e => e.PUR07_NO == key) > 0;
        }
    }
}
