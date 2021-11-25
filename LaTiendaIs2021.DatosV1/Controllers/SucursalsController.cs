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
    public class SucursalsController : ApiController
    {
        private LaTiendaIs2021DatosV1Context db = new LaTiendaIs2021DatosV1Context();

        // GET: api/Sucursals
        public IQueryable<Sucursal> GetSucursals()
        {
            return db.Sucursals;
        }

        // GET: api/Sucursals/5
        [ResponseType(typeof(Sucursal))]
        public async Task<IHttpActionResult> GetSucursal(int id)
        {
            Sucursal sucursal = await db.Sucursals.FindAsync(id);
            if (sucursal == null)
            {
                return NotFound();
            }

            return Ok(sucursal);
        }

        // PUT: api/Sucursals/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSucursal(int id, Sucursal sucursal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sucursal.Id)
            {
                return BadRequest();
            }

            db.Entry(sucursal).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SucursalExists(id))
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

        // POST: api/Sucursals
        [ResponseType(typeof(Sucursal))]
        public async Task<IHttpActionResult> PostSucursal(Sucursal sucursal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sucursals.Add(sucursal);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = sucursal.Id }, sucursal);
        }

        // DELETE: api/Sucursals/5
        [ResponseType(typeof(Sucursal))]
        public async Task<IHttpActionResult> DeleteSucursal(int id)
        {
            Sucursal sucursal = await db.Sucursals.FindAsync(id);
            if (sucursal == null)
            {
                return NotFound();
            }

            db.Sucursals.Remove(sucursal);
            await db.SaveChangesAsync();

            return Ok(sucursal);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SucursalExists(int id)
        {
            return db.Sucursals.Count(e => e.Id == id) > 0;
        }
    }
}