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
using System.Web.Http.Description;
using MyWinery;

namespace MyWinery.Controllers
{

    [RoutePrefix("api")]
    public class WinesController : BaseController
    {
        //GET: api/Wines
        [AcceptVerbs("POST", "PUT")]
        [HttpGet]
        [Route("lista")]
        public async Task<List<Wines>> ListWines()
        {
            var wines = await _context.Wines.ToListAsync();
            return wines;
        }

        //GET: api/Wines/5
        
        [HttpGet]
        [Route("wineById")]
        public async Task<Wines> GetWines([FromUri]int id)
        {
            Wines wineById = await _context.Wines.FirstOrDefaultAsync(i => i.Id == id);
            return wineById;
        }

        [AcceptVerbs("POST", "PUT")]
        [HttpGet]
        [Route("user")]
        public string GetUserIdentity()
        {

            return User.Identity.Name;
        }

        // EDIT PUT: api/Wines/5
        //    [ResponseType(typeof(void))]
        [HttpPut]
        [AcceptVerbs("POST")]
        [Route("putWine")]
        public async Task<IHttpActionResult> PutWines([FromBody]Wines wines)
        {
            Wines selectedWine = await _context.Wines.FirstOrDefaultAsync(w => w.Id == wines.Id);
            
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //if (id != editedWine.Id)
            //{
              //return BadRequest();
            //}

            _context.Entry(selectedWine).CurrentValues.SetValues(wines);

            //try
            //{
                await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!WinesExists(wines.Id))
            //    {
                //    return NotFound();
                //}
                //else
                //{
                //    throw;
                //}
            //}

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST CREATE: api/Wines
        [ResponseType(typeof(Wines))]
        [AcceptVerbs("POST", "PUT")]
        [HttpPost]
        [Route("postWine")]
        public async Task<IHttpActionResult> PostWines([FromBody]Wines wines)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Wines.Add(wines);
            await _context.SaveChangesAsync();
            return CreatedAtRoute("postWine", new { id = wines.Id }, wines); //da cambiare "Default" con nuovo route config
        }

        // POST DELETE: api/Wines/5

        [HttpPost]
        [AcceptVerbs("Post")]
        [Route("deleteWine")]
        public async Task<IHttpActionResult> DeleteWines([FromBody]int id)
        {
            Wines wines = await _context.Wines.FirstOrDefaultAsync(wi => wi.Id == id);
            if (wines == null)
            {
                return BadRequest(ModelState);
            }

            _context.Wines.Remove(wines);
            await _context.SaveChangesAsync();

            return Ok("Vino cancellato!");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        _context.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
        private bool WinesExists(int id)
        {
            return _context.Wines.Count(e => e.Id == id) > 0;
        }
    }
}



