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
using LaTiendaIS2021.Dominio.Modelo;
using LaTiendaIs2021.DatosV1.Data;

namespace LaTiendaIs2021.DatosV1.Controllers
{
    public class TallesController : ApiController
    {
        private LaTiendaIs2021DatosV1Context db = new LaTiendaIs2021DatosV1Context();

        // GET: api/Talles
        public IQueryable<Talle> GetTalles()
        {
            return db.Talles;
        }

        // GET: api/Talles/5
        [ResponseType(typeof(Talle))]
        public async Task<IHttpActionResult> GetTalle(int id)
        {
            Talle talle = await db.Talles.FindAsync(id);
            if (talle == null)
            {
                return NotFound();
            }

            return Ok(talle);
        }

        // PUT: api/Talles/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTalle(int id, Talle talle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != talle.Id)
            {
                return BadRequest();
            }

            db.Entry(talle).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TalleExists(id))
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

        // POST: api/Talles
        [ResponseType(typeof(Talle))]
        public async Task<IHttpActionResult> PostTalle(Talle talle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Talles.Add(talle);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = talle.Id }, talle);
        }

        // DELETE: api/Talles/5
        [ResponseType(typeof(Talle))]
        public async Task<IHttpActionResult> DeleteTalle(int id)
        {
            Talle talle = await db.Talles.FindAsync(id);
            if (talle == null)
            {
                return NotFound();
            }

            db.Talles.Remove(talle);
            await db.SaveChangesAsync();

            return Ok(talle);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TalleExists(int id)
        {
            return db.Talles.Count(e => e.Id == id) > 0;
        }
    }
}