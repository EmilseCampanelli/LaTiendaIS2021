using LaTiendaIs2021.DatosV1.Data;
using LaTiendaIS2021.Dominio.Modelo;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace LaTiendaIs2021.DatosV1.Controllers
{
    public class SucursalsController : ApiController
    {
        private LaTiendaIs2021DatosV1Context db = new LaTiendaIs2021DatosV1Context();

        // GET: api/Sucursals
        public IHttpActionResult GetSucursals()
        {
            try
            {
                var s = db.Sucursals;
                return Json(s, new Newtonsoft.Json.JsonSerializerSettings { ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore });
            }
            catch (Exception ex)
            {
                return null;
            }
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



        // POST: api/Sucursals
        [ResponseType(typeof(Sucursal))]
        public async Task<IHttpActionResult> PostSucursal(Sucursal sucursal)
        {
            int bandera = 0;
            try
            {
                foreach (var i in db.Sucursals)
                {
                    if (i.Descripcion == sucursal.Descripcion)
                    {
                        bandera = i.Id;
                    }

                }
            }
            catch
            {

            }
            return Ok(bandera);
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