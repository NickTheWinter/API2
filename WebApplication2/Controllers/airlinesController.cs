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
using WebApplication2.Entyties;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class airlinesController : ApiController
    {
        private Entities1 db = new Entities1();

        // GET: api/airlines
        [ResponseType(typeof(List<airlineModel>))]
        public IHttpActionResult Getairlines()
        {
            return Ok(db.airlines.ToList().ConvertAll(x=> new airlineModel(x)));
        }

        // GET: api/airlines/5
        [ResponseType(typeof(List<airlineModel>))]
        public IHttpActionResult Getairlines(int id)
        {
            airlines airlines = db.airlines.Find(id);
            if (airlines == null)
            {
                return NotFound();
            }

            return Ok(airlines);
        }

        // PUT: api/airlines/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putairlines(int id, airlines airlines)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != airlines.airline_id)
            {
                return BadRequest();
            }

            db.Entry(airlines).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!airlinesExists(id))
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

        // POST: api/airlines
        [ResponseType(typeof(airlines))]
        public IHttpActionResult Postairlines(airlines airlines)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.airlines.Add(airlines);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = airlines.airline_id }, airlines);
        }

        // DELETE: api/airlines/5
        [ResponseType(typeof(airlines))]
        public IHttpActionResult Deleteairlines(int id)
        {
            airlines airlines = db.airlines.Find(id);
            if (airlines == null)
            {
                return NotFound();
            }

            db.airlines.Remove(airlines);
            db.SaveChanges();

            return Ok(airlines);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool airlinesExists(int id)
        {
            return db.airlines.Count(e => e.airline_id == id) > 0;
        }
    }
}