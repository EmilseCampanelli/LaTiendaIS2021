﻿using System.Collections.Generic;
using System.Linq;

namespace LaTiendaIS2021.Dominio.Modelo
{
    public class Venta
    {
        public virtual List<LineaVenta> LineaVenta { get; set; } //
        public Venta()
        {
            
            CalcularTotalVenta();
        }
        public int id { get; set; }
        public System.DateTime? fecha { get; set; }
        public decimal total { get; set; }

        public int ClienteId { get; set; }
        public int PuntoVentaId { get; set; }
        public int UsuarioId { get; set; }
        public virtual Cliente Cliente { get; set; }


        public virtual PuntoVenta PuntoVenta { get; set; }
        public virtual Usuario Usuario { get; set; }


        public void agregarLineaVenta(LineaVenta lineaVenta)
        {
            LineaVenta.Add(lineaVenta);
        }

        public bool ExistenLineasdeVenta()
        {
            return LineaVenta.Any();
        }

        public decimal CalcularTotalVenta()
        {
            total = 0;
            foreach (var i in LineaVenta)
            {
                total = (decimal)(total + i.precio);
            }

            return total;
        }

        public void EliminarLineaVenta(int id)
        {
            var linea = (from i in LineaVenta
                         where i.id == id
                         select i).FirstOrDefault();

            LineaVenta.Remove(linea);
        }

        public bool BuscarLineaVenta(int id)
        {
            var vs = (from i in LineaVenta
                      where i.id == id
                      select i);

            if (vs.Count() > 0) return true;
            else return false;
        }



        public void StockUpdate()
        {
            foreach(var lv in LineaVenta)
            {
                var prod = lv.Producto;
                if (GetStock(prod) != null){
                    if(GetStock(prod).ColorId == lv.ColorId && GetStock(prod).TalleId == lv.TalleId)
                    {
                        Stock s = GetStock(prod);
                        SetStock(s, lv);
                    }
                }
            }
        }


        public Stock GetStock(Producto producto)
        {
            foreach(var stock in producto.Stock)
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
