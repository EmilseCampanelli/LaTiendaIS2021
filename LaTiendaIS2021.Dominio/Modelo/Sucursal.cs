using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTiendaIS2021.Dominio.Modelo
{
    public class Sucursal
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

       /* public virtual ICollection<PuntoVenta> PuntoVentas { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }*/
    }
}
