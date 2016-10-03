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
    builder.EntitySet<PCM010>("PCM010");
    config.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class PCM010Controller : ODataController
    {
        private ModelDbContext db = new ModelDbContext();

        // GET: odata/PCM010
        [EnableQuery]
        public IQueryable<PCM010> GetPCM010()
        {
            return db.PCM010;
        }

        // GET: odata/PCM010(5)
        [EnableQuery]
        public SingleResult<PCM010> GetPCM010([FromODataUri] string key)
        {
            return SingleResult.Create(db.PCM010.Where(pCM010 => pCM010.DIE_NO == key));
        }

        // PUT: odata/PCM010(5)
        public async Task<IHttpActionResult> Put([FromODataUri] string key, Delta<PCM010> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            PCM010 pCM010 = await db.PCM010.FindAsync(key);
            if (pCM010 == null)
            {
                return NotFound();
            }

            patch.Put(pCM010);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PCM010Exists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(pCM010);
        }

        // POST: odata/PCM010
        public async Task<IHttpActionResult> Post(PCM010 pCM010)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PCM010.Add(pCM010);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PCM010Exists(pCM010.DIE_NO))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Created(pCM010);
        }

        // PATCH: odata/PCM010(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] string key, Delta<PCM010> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            PCM010 pCM010 = await db.PCM010.FindAsync(key);
            if (pCM010 == null)
            {
                return NotFound();
            }

            patch.Patch(pCM010);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PCM010Exists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(pCM010);
        }

        // DELETE: odata/PCM010(5)
        public async Task<IHttpActionResult> Delete([FromODataUri] string key)
        {
            PCM010 pCM010 = await db.PCM010.FindAsync(key);
            if (pCM010 == null)
            {
                return NotFound();
            }

            db.PCM010.Remove(pCM010);
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

        private bool PCM010Exists(string key)
        {
            return db.PCM010.Count(e => e.DIE_NO == key) > 0;
        }
    }
}
