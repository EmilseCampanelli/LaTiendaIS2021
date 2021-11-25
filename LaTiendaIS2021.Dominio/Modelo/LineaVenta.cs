using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTiendaIS2021.Dominio.Modelo
{
    public class LineaVenta
    {
        public int id { get; set; }
        public int? cantidad { get; set; }
        public decimal? precio => CalcularSubtotal();
        
        public int ProductoId { get; set; }
        public int VentaId { get; set; }

        public virtual Producto Producto { get; set; }
        public virtual Venta Venta { get; set; }

        public bool CantidadProducto()
        {
            if (cantidad > 0)
            {
                return true;
            }
            else return false;
        }

        public decimal? CalcularSubtotal()
        {
            return cantidad * Producto.PrecioFinal;
           
        }

       
    }
}
