using LaTiendaIs2021.DatosV1.Data;
using LaTiendaIS2021.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace LaTiendaIs2021.DatosV1.Controllers
{
    public class ProductoesController : ApiController
    {
        private LaTiendaIs2021DatosV1Context db = new LaTiendaIs2021DatosV1Context();

        // GET: api/Productoes
        public IQueryable<Producto> GetProducto()
        {
            return db.Productoes;
        }

        // GET: api/Productoes/5
       // [ResponseType(typeof(Producto))]
        public IHttpActionResult GetProducto(int codProd)
        {
            try
            {
                var p = (from d in db.Productoes
                         where d.Codigo == codProd
                         select d).ToList();

                // Producto producto = await db.Productoes.FindAsync(id);
                return Json(p,new Newtonsoft.Json.JsonSerializerSettings {ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore });

                
            }
            catch(Exception ex)
            {
                return null;
            }
           
        }


        // PUT: api/Productoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProducto(int id, Producto producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != producto.Id)
            {
                return BadRequest();
            }

            db.Entry(producto).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductoExists(id))
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

        // POST: api/Productoes
        [ResponseType(typeof(Producto))]
        public async Task<IHttpActionResult> PostProducto(Producto producto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                producto.MargenGanancia = Math.Round((decimal)producto.MargenGanancia, 2);
                db.Productoes.Add(producto);
                await db.SaveChangesAsync();

                return Ok("Exito");//CreatedAtRoute("DefaultApi", new { id = producto.Id }, producto);
            }
            catch (Exception e)
            {
                return Ok(e);
            }

        }

        // DELETE: api/Productoes/5
        [ResponseType(typeof(Producto))]
        public async Task<IHttpActionResult> DeleteProducto(int id)
        {
            Producto producto = await db.Productoes.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }

            db.Productoes.Remove(producto);
            await db.SaveChangesAsync();

            return Ok(producto);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductoExists(int id)
        {
            return db.Productoes.Count(e => e.Id == id) > 0;
        }
    }
}