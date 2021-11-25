
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTiendaIS2021.Dominio.Modelo
{
    public class Producto
    {
        private decimal? precio = 0, margen = 0;
        public int Id { get; set; }
        public int? Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal? CostoSinIva { get; set; } //CostoProducto
        public decimal? PorcentajeIva { get; set; }
        public decimal? MargenGanancia { get => margen; set { margen = value; precio = CostoConIva * (1 + MargenGanancia); } } //Margen de Ganancia
      


        public decimal? CostoConIva => CostoSinIva * (1 + PorcentajeIva);
        public decimal? PrecioFinal => CostoConIva * (1 + MargenGanancia);
        public int MarcaId { get; set; }
        public int RubroId { get; set; }
        public virtual Marca Marca { get; set; }
        
        public virtual Rubro Rubro { get; set; }

       
    }
}
