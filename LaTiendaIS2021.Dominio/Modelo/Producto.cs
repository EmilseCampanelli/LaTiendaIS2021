
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTiendaIS2021.Dominio.Modelo
{
    public class Producto
    {
       
        public int Id { get; set; }
        public int? Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal CostoSinIva { get; set; } //CostoProducto
        public decimal PorcentajeIva { get; set; }
        public decimal MargenGanancia { get; set; } //Margen de Ganancia

        public decimal NetoGravado => CostoSinIva * (1 + MargenGanancia);
        public decimal CostoConIva => NetoGravado + PorcentajeIva;
        public decimal PrecioVenta => NetoGravado + CostoConIva;
        
        public int MarcaId { get; set; }
        public int RubroId { get; set; }
        public virtual Marca Marca { get; set; }
        
        public virtual Rubro Rubro { get; set; }

       
    }
}
