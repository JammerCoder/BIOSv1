using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BIOS.Data.Entity;
using BIOS.Model.Models;

namespace BIOS.Web.Controllers.Racks
{
    public class RacksAPIController : ApiController
    {
        private BIOSDbContext db = new BIOSDbContext();

        // GET: api/RacksAPI
        public IQueryable<Rack> GetRacks()
        {
            return db.Racks;
        }

        // GET: api/RacksAPI/5
        [ResponseType(typeof(Rack))]
        public IHttpActionResult GetRack(Guid id)
        {
            Rack rack = db.Racks.Find(id);
            if (rack == null)
            {
                return NotFound();
            }

            return Ok(rack);
        }

        // PUT: api/RacksAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRack(Guid id, Rack rack)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rack.Id)
            {
                return BadRequest();
            }

            db.Entry(rack).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RackExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/RacksAPI
        [ResponseType(typeof(Rack))]
        public IHttpActionResult PostRack(Rack rack)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Racks.Add(rack);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (RackExists(rack.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = rack.Id }, rack);
        }

        // DELETE: api/RacksAPI/5
        [ResponseType(typeof(Rack))]
        public IHttpActionResult DeleteRack(Guid id)
        {
            Rack rack = db.Racks.Find(id);
            if (rack == null)
            {
                return NotFound();
            }

            db.Racks.Remove(rack);
            db.SaveChanges();

            return Ok(rack);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RackExists(Guid id)
        {
            return db.Racks.Count(e => e.Id == id) > 0;
        }
    }
}