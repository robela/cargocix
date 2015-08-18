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
    public class ReceiptDelayController : ApiController
    {
        private CargoclixContext db = new CargoclixContext();

        // GET api/ReceiptDelay
       
        public IHttpActionResult Get()
        {

            List<ReceiptDelay> k = db.ReceiptDelays.ToList();
            return Ok(k);
        }
        // GET api/ReceiptDelay/5
        [ResponseType(typeof(ReceiptDelay))]
        public IHttpActionResult GetReceiptDelay(int id)
        {
            ReceiptDelay receiptdelay = db.ReceiptDelays.Find(id);
            if (receiptdelay == null)
            {
                return NotFound();
            }

            return Ok(receiptdelay);
        }

        // PUT api/ReceiptDelay/5
        public IHttpActionResult PutReceiptDelay(int id, ReceiptDelay receiptdelay)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != receiptdelay.receiptDelayId)
            {
                return BadRequest();
            }

            db.Entry(receiptdelay).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReceiptDelayExists(id))
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

        // POST api/ReceiptDelay
        [ResponseType(typeof(ReceiptDelay))]
        public IHttpActionResult PostReceiptDelay(ReceiptDelay receiptdelay)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ReceiptDelays.Add(receiptdelay);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ReceiptDelayExists(receiptdelay.receiptDelayId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = receiptdelay.receiptDelayId }, receiptdelay);
        }

        // DELETE api/ReceiptDelay/5
        [ResponseType(typeof(ReceiptDelay))]
        public IHttpActionResult DeleteReceiptDelay(int id)
        {
            ReceiptDelay receiptdelay = db.ReceiptDelays.Find(id);
            if (receiptdelay == null)
            {
                return NotFound();
            }

            db.ReceiptDelays.Remove(receiptdelay);
            db.SaveChanges();

            return Ok(receiptdelay);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ReceiptDelayExists(int id)
        {
            return db.ReceiptDelays.Count(e => e.receiptDelayId == id) > 0;
        }
    }
}