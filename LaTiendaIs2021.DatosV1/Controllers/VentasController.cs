using LaTiendaIs2021.DatosV1.Data;
using LaTiendaIS2021.Dominio.Modelo;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace LaTiendaIs2021.DatosV1.Controllers
{
    public class VentasController : ApiController
    {
        private LaTiendaIs2021DatosV1Context db = new LaTiendaIs2021DatosV1Context();

        // GET: api/Ventas
        public IQueryable<Venta> GetVentas()
        {
            return db.Ventas;
        }

        // GET: api/Ventas/5
        [ResponseType(typeof(Venta))]
        public async Task<IHttpActionResult> GetVenta(int id)
        {
            Venta venta = await db.Ventas.FindAsync(id);
            if (venta == null)
            {
                return NotFound();
            }

            return Ok(venta);
        }

        // PUT: api/Ventas/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVenta(int id, Venta venta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != venta.id)
            {
                return BadRequest();
            }

            db.Entry(venta).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VentaExists(id))
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

        // POST: api/Ventas
        [ResponseType(typeof(Venta))]
        public IHttpActionResult PostVenta(Venta venta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                venta.Cliente = db.Clientes?.Find(venta.ClienteId);
                venta.PuntoVenta = db.PuntoVentas?.Find(venta.PuntoVentaId);
                venta.Usuario = db.Usuarios?.Find(venta.UsuarioId);

                foreach(var lv in venta.LineaVenta)
                {
                    lv.Talle = db.Talles?.Find(lv.TalleId);
                    lv.Color = db.Colors?.Find(lv.ColorId);
                 
                    var stock = lv.Producto.Stock;
                    lv.Producto = db.Productoes?.Find(lv.ProductoId);

                    foreach(var s in stock)
                    {
                        s.Color = db.Colors?.Find(s.ColorId);
                        s.Talle = db.Talles?.Find(s.TalleId);
                        s.Sucursal = db.Sucursals?.Find(s.SucursalId);

                        db.Entry(s).State = EntityState.Modified;
                       
                    }
                   

                }
            

                db.Ventas.Add(venta);
                db.SaveChanges();

                venta.id = db.Entry(venta).Entity.id;
                return Ok(venta);
            }
            catch (Exception e)
            {
                return Ok(e);
            }
            
        }

        // DELETE: api/Ventas/5
        [ResponseType(typeof(Venta))]
        public async Task<IHttpActionResult> DeleteVenta(int id)
        {
            Venta venta = await db.Ventas.FindAsync(id);
            if (venta == null)
            {
                return NotFound();
            }

            db.Ventas.Remove(venta);
            await db.SaveChangesAsync();

            return Ok(venta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VentaExists(int id)
        {
            return db.Ventas.Count(e => e.id == id) > 0;
        }
    }
}