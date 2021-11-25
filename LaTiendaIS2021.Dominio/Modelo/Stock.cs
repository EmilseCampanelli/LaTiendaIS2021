using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTiendaIS2021.Dominio.Modelo
{
    public class Stock
    {
        public int id { get; set; }
        public int? cantidad { get; set; }
      

        public int ColorId { get; set; }
        public int ProductoId { get; set; }
        public int SucursalId { get; set; }
        public int TalleId { get; set; }
        public virtual Color Color { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        public virtual Talle Talle { get; set; }
    }
}
