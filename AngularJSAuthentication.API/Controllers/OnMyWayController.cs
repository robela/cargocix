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
using AngularJSAuthentication.API.Models;

namespace AngularJSAuthentication.API.Controllers
{
    public class OnMyWayController : ApiController
    {
        private CargoclixContext db = new CargoclixContext();

        // GET api/OnMyWay
        public IQueryable<OnMyWay> GetOnMyWays()
        {
            return db.OnMyWays;
        }

        // GET api/OnMyWay/5
        [ResponseType(typeof(OnMyWay))]
        public IHttpActionResult GetOnMyWay(int id)
        {
            OnMyWay onmyway = db.OnMyWays.Find(id);
            if (onmyway == null)
            {
                return NotFound();
            }

            return Ok(onmyway);
        }

        // PUT api/OnMyWay/5
        public IHttpActionResult PutOnMyWay(int id, OnMyWay onmyway)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != onmyway.onMyWayId)
            {
                return BadRequest();
            }

            db.Entry(onmyway).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OnMyWayExists(id))
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

        // POST api/OnMyWay
        [ResponseType(typeof(OnMyWay))]
        public IHttpActionResult PostOnMyWay(OnMyWay onmyway)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OnMyWays.Add(onmyway);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = onmyway.onMyWayId }, onmyway);
        }

        // DELETE api/OnMyWay/5
        [ResponseType(typeof(OnMyWay))]
        public IHttpActionResult DeleteOnMyWay(int id)
        {
            OnMyWay onmyway = db.OnMyWays.Find(id);
            if (onmyway == null)
            {
                return NotFound();
            }

            db.OnMyWays.Remove(onmyway);
            db.SaveChanges();

            return Ok(onmyway);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OnMyWayExists(int id)
        {
            return db.OnMyWays.Count(e => e.onMyWayId == id) > 0;
        }
    }
}