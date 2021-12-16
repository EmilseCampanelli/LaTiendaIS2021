using LaTiendaIs2021.DatosV1.Data;
using LaTiendaIS2021.Dominio.Modelo;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

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