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
    public class LineaVentasController : ApiController
    {
        private LaTiendaIs2021DatosV1Context db = new LaTiendaIs2021DatosV1Context();

        // GET: api/LineaVentas
        public IQueryable<LineaVenta> GetLineaVentas()
        {
            return db.LineaVentas;
        }

        // GET: api/LineaVentas/5
        [ResponseType(typeof(LineaVenta))]
        public async Task<IHttpActionResult> GetLineaVenta(int id)
        {
            LineaVenta lineaVenta = await db.LineaVentas.FindAsync(id);
            if (lineaVenta == null)
            {
                return NotFound();
            }

            return Ok(lineaVenta);
        }

        // PUT: api/LineaVentas/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutLineaVenta(int id, LineaVenta lineaVenta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lineaVenta.id)
            {
                return BadRequest();
            }

            db.Entry(lineaVenta).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LineaVentaExists(id))
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

        // POST: api/LineaVentas
        [ResponseType(typeof(LineaVenta))]
        public async Task<IHttpActionResult> PostLineaVenta(LineaVenta lineaVenta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LineaVentas.Add(lineaVenta);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = lineaVenta.id }, lineaVenta);
        }

        // DELETE: api/LineaVentas/5
        [ResponseType(typeof(LineaVenta))]
        public async Task<IHttpActionResult> DeleteLineaVenta(int id)
        {
            LineaVenta lineaVenta = await db.LineaVentas.FindAsync(id);
            if (lineaVenta == null)
            {
                return NotFound();
            }

            db.LineaVentas.Remove(lineaVenta);
            await db.SaveChangesAsync();

            return Ok(lineaVenta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LineaVentaExists(int id)
        {
            return db.LineaVentas.Count(e => e.id == id) > 0;
        }
    }
}