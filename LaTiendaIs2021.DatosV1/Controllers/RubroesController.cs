using LaTiendaIs2021.DatosV1.Data;
using LaTiendaIS2021.Dominio.Modelo;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

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