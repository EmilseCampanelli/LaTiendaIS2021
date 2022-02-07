using System.Collections.Generic;

namespace LaTiendaIS2021.Dominio.Modelo
{
    public class Producto
    {

        public Producto()
        {
            this.Stock = new List<Stock>();
        }
        public int Id { get; set; }
        public int? Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal CostoSinIva { get; set; } //CostoProducto
        public decimal PorcentajeIva { get; set; }
        public decimal MargenGanancia { get; set; } //Margen de Ganancia

        public decimal NetoGravado => CostoSinIva * (1 + MargenGanancia);
        public decimal CostoConIva => NetoGravado + PorcentajeIva;

        public decimal PrecioVenta { get => NetoGravado + CostoConIva; set => value = NetoGravado + CostoConIva; }


        public int MarcaId { get; set; }
        public int RubroId { get; set; }
        public virtual Marca Marca { get; set; }

        public virtual Rubro Rubro { get; set; }

        public virtual ICollection<Stock> Stock { get; set; }

        public string MarcaDescripcion
        {
            get { return Marca?.Descripcion; }
        }

        public string RubroDescripcion
        {
            get { return Rubro?.Descripcion; }
        }


        

        public void SetStock(Stock stock, int Cantidad)
        {
            stock.cantidad -= Cantidad;
        }

    }
}
