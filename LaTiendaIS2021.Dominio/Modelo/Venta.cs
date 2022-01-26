using System.Collections.Generic;
using System.Linq;

namespace LaTiendaIS2021.Dominio.Modelo
{
    public class Venta
    {
        //
        public Venta()
        {

            //CalcularTotalVenta();
            this.LineaVenta = new HashSet<LineaVenta>();

        }
        public virtual ICollection<LineaVenta> LineaVenta { get; set; }
        public int id { get; set; }
        public System.DateTime? fecha { get; set; }
        public decimal total { get; set; }

        public int ClienteId { get; set; }
        public int PuntoVentaId { get; set; }
     
        public int UsuarioId { get; set; }
        public virtual Cliente Cliente { get; set; }

        public virtual PuntoVenta PuntoVenta { get; set; }
        public virtual Usuario Usuario { get; set; }
        


        public decimal CalcularTotalVenta()
        {
            total = 0;
            foreach (var i in LineaVenta)
            {
                total = (decimal)(total + i.precio);
            }

            return total;
        }


        public void ConfirmarVenta()
        {
            StockUpdate();
        }

        //Colocar en la Linea de venta solo dentro del foreach
        private void StockUpdate()
        {
            foreach (var lv in LineaVenta)
            {
                var prod = lv.Producto;
                if (GetStock(prod) != null)
                {
                    if (GetStock(prod).ColorId == lv.ColorId && GetStock(prod).TalleId == lv.TalleId)
                    {
                        Stock s = GetStock(prod);
                        if(s.SucursalId == PuntoVenta.SucursalId)
                        {
                            SetStock(s, lv);
                        }
                        
                    }
                }
            }
        }

        //Colorcar en el producto
        //Comparar la sucursal
        public Stock GetStock(Producto producto)
        {
            foreach (var stock in producto.Stock)
            {
                return stock;
            }
            return null;
        }

        public void SetStock(Stock stock, LineaVenta lineaVenta)
        {
            stock.cantidad -= lineaVenta.cantidad;
        }
    }


}
