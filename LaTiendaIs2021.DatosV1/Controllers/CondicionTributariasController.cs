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
    public class CondicionTributariasController : ApiController
    {
        private LaTiendaIs2021DatosV1Context db = new LaTiendaIs2021DatosV1Context();

        // GET: api/CondicionTributarias
        public IQueryable<CondicionTributaria> GetCondicionTributarias()
        {
            return db.CondicionTributarias;
        }

        // GET: api/CondicionTributarias/5
        [ResponseType(typeof(CondicionTributaria))]
        public async Task<IHttpActionResult> GetCondicionTributaria(int id)
        {
            CondicionTributaria condicionTributaria = await db.CondicionTributarias.FindAsync(id);
            if (condicionTributaria == null)
            {
                return NotFound();
            }

            return Ok(condicionTributaria);
        }

        // PUT: api/CondicionTributarias/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCondicionTributaria(int id, CondicionTributaria condicionTributaria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != condicionTributaria.Id)
            {
                return BadRequest();
            }

            db.Entry(condicionTributaria).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CondicionTributariaExists(id))
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

        // POST: api/CondicionTributarias
        [ResponseType(typeof(CondicionTributaria))]
        public async Task<IHttpActionResult> PostCondicionTributaria(CondicionTributaria condicionTributaria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CondicionTributarias.Add(condicionTributaria);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = condicionTributaria.Id }, condicionTributaria);
        }

        // DELETE: api/CondicionTributarias/5
        [ResponseType(typeof(CondicionTributaria))]
        public async Task<IHttpActionResult> DeleteCondicionTributaria(int id)
        {
            CondicionTributaria condicionTributaria = await db.CondicionTributarias.FindAsync(id);
            if (condicionTributaria == null)
            {
                return NotFound();
            }

            db.CondicionTributarias.Remove(condicionTributaria);
            await db.SaveChangesAsync();

            return Ok(condicionTributaria);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CondicionTributariaExists(int id)
        {
            return db.CondicionTributarias.Count(e => e.Id == id) > 0;
        }
    }
}