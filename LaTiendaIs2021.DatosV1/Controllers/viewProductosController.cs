using LaTiendaIs2021.DatosV1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LaTiendaIs2021.DatosV1.Controllers
{
    public class viewProductosController : ApiController
    {
        private LaTiendaIs2021DatosV1Context db = new LaTiendaIs2021DatosV1Context();

        // GET: api/Productoes
        public IHttpActionResult GetProductoes()
        {
            var p = (from d in db.Productoes
                     join r in db.Rubroes on d.RubroId equals r.Id
                     join m in db.Marcas on d.MarcaId equals m.Id

                     select new
                     {
                         codigo = d.Codigo,
                         Descripcion = d.Descripcion,
                         Marca = m.Descripcion,
                         Rubro = r.Descripcion
                     }).ToList();

            return Ok(p);

        }
    }
}
