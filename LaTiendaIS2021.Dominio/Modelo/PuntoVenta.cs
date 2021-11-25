using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTiendaIS2021.Dominio.Modelo
{
    public class PuntoVenta
    {
        public int id { get; set; }
        public string descripcion { get; set; }
      
        public int SucursalId { get; set; }
        public virtual Sucursal Sucursal { get; set; }
     
        
        
    }
}
