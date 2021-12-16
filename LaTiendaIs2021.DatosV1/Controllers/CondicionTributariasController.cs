using LaTiendaIs2021.DatosV1.Data;
using LaTiendaIS2021.Dominio.Modelo;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

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