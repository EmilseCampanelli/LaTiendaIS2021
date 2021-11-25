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
    public class RubroesController : ApiController
    {
        private LaTiendaIs2021DatosV1Context db = new LaTiendaIs2021DatosV1Context();

        // GET: api/Rubroes
        public IQueryable<Rubro> GetRubroes()
        {
            return db.Rubroes;
        }

        // GET: api/Rubroes/5
        [ResponseType(typeof(Rubro))]
        public async Task<IHttpActionResult> GetRubro(int id)
        {
            Rubro rubro = await db.Rubroes.FindAsync(id);
            if (rubro == null)
            {
                return NotFound();
            }

            return Ok(rubro);
        }

        // PUT: api/Rubroes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutRubro(int id, Rubro rubro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rubro.Id)
            {
                return BadRequest();
            }

            db.Entry(rubro).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RubroExists(id))
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

        // POST: api/Rubroes
        [ResponseType(typeof(Rubro))]
        public async Task<IHttpActionResult> PostRubro(Rubro rubro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Rubroes.Add(rubro);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = rubro.Id }, rubro);
        }

        // DELETE: api/Rubroes/5
        [ResponseType(typeof(Rubro))]
        public async Task<IHttpActionResult> DeleteRubro(int id)
        {
            Rubro rubro = await db.Rubroes.FindAsync(id);
            if (rubro == null)
            {
                return NotFound();
            }

            db.Rubroes.Remove(rubro);
            await db.SaveChangesAsync();

            return Ok(rubro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RubroExists(int id)
        {
            return db.Rubroes.Count(e => e.Id == id) > 0;
        }
    }
}