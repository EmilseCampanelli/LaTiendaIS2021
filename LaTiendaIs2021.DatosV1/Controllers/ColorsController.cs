using LaTiendaIs2021.DatosV1.Data;
using LaTiendaIS2021.Dominio.Modelo;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace LaTiendaIs2021.DatosV1.Controllers
{
    public class ColorsController : ApiController
    {
        private LaTiendaIs2021DatosV1Context db = new LaTiendaIs2021DatosV1Context();

        // GET: api/Colors
        public IQueryable<Color> GetColors()
        {
            return db.Colors;
        }

        // GET: api/Colors/5
        [ResponseType(typeof(Color))]
        public async Task<IHttpActionResult> GetColor(int id)
        {
            Color color = await db.Colors.FindAsync(id);
            if (color == null)
            {
                return NotFound();
            }

            return Ok(color);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ColorExists(int id)
        {
            return db.Colors.Count(e => e.Id == id) > 0;
        }
    }
}