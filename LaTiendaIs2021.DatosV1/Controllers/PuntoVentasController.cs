using LaTiendaIs2021.DatosV1.Data;
using LaTiendaIS2021.Dominio.Modelo;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

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
        public async Task<IHttpActionResult> GetPuntoVenta(int suc)
        {
            var pv = (from i in db.PuntoVentas
                      where i.SucursalId == suc
                      select i);

            return Ok(pv.ToList());
        }



        // POST: api/PuntoVentas
        [ResponseType(typeof(PuntoVenta))]
        public async Task<IHttpActionResult> PostPuntoVenta(PuntoVenta puntoVenta)
        {
            int bandera = 0;
            try
            {
                foreach (var i in db.PuntoVentas)
                {
                    if (i.descripcion == puntoVenta.descripcion &&
                        i.SucursalId == puntoVenta.SucursalId)
                    {
                        bandera = i.id;
                    }
                }
            }
            catch
            {

            }
            return Ok(bandera);
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