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
    public class PuntoVentasController : ApiController
    {
        private LaTiendaIs2021DatosV1Context db = new LaTiendaIs2021DatosV1Context();

        // GET: api/PuntoVentas
        public IQueryable<PuntoVenta> GetPuntoVentas()
        {
            return db.PuntoVentas;
        }

        // GET: api/PuntoVentas/5
        [ResponseType(typeof(PuntoVenta))]
        public async Task<IHttpActionResult> GetPuntoVenta(int id)
        {
            PuntoVenta puntoVenta = await db.PuntoVentas.FindAsync(id);
            if (puntoVenta == null)
            {
                return NotFound();
            }

            return Ok(puntoVenta);
        }

        // PUT: api/PuntoVentas/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPuntoVenta(int id, PuntoVenta puntoVenta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != puntoVenta.id)
            {
                return BadRequest();
            }

            db.Entry(puntoVenta).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PuntoVentaExists(id))
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

        // POST: api/PuntoVentas
        [ResponseType(typeof(PuntoVenta))]
        public async Task<IHttpActionResult> PostPuntoVenta(PuntoVenta puntoVenta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PuntoVentas.Add(puntoVenta);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = puntoVenta.id }, puntoVenta);
        }

        // DELETE: api/PuntoVentas/5
        [ResponseType(typeof(PuntoVenta))]
        public async Task<IHttpActionResult> DeletePuntoVenta(int id)
        {
            PuntoVenta puntoVenta = await db.PuntoVentas.FindAsync(id);
            if (puntoVenta == null)
            {
                return NotFound();
            }

            db.PuntoVentas.Remove(puntoVenta);
            await db.SaveChangesAsync();

            return Ok(puntoVenta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PuntoVentaExists(int id)
        {
            return db.PuntoVentas.Count(e => e.id == id) > 0;
        }
    }
}