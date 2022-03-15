using LaTiendaIS2021.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTiendaIS2021.Test
{
    public static class Factory
    {
        public static PuntoVenta PuntoVentaFactory()
        {
            var pv = new PuntoVenta()
            {
                id = 18,
                descripcion = "18",
                SucursalId = 1
            };

            return pv;
        }
        public static Producto ProductFactory()
        {
            var prod1 = new Producto()
            {
                Id = 1,
                Codigo = 1,
                Descripcion = "Jean",
                CostoSinIva = 300,
                MargenGanancia = 30,
                PorcentajeIva = 21,
                MarcaId = MarcaFactory().Id,
                RubroId = RubroFactory().Id,
                Stock = AddStock(),
            };

            return prod1;
        }

        public static Marca MarcaFactory()
        {
            var marca = new Marca()
            {
                Id = 1,
                Descripcion = "Adidas"
            };
            return marca;
        }

        public static Rubro RubroFactory()
        {
            var rubro = new Rubro()
            {
                Id = 1,
                Descripcion = "Deportivo"
            };
            return rubro;
        }

        public static LineaVenta LvFatory1()
        {
            var Lv = new LineaVenta()
            {
                id = 1,
                cantidad = 2,
                ProductoId = ProductFactory().Id,
                Producto = ProductFactory(),
                ColorId = ColorFactory().Id,
                Color = ColorFactory(),
                Talle = TalleFactory(),
                TalleId = TalleFactory().Id,
                VentaId = 1,

            };

            return Lv;
        }

        public static Color ColorFactory()
        {
            var color = new Color()
            {
                Id = 1,
                Descripcion = "Morado"
            };
            return color;
        }

        public static Talle TalleFactory()
        {
            var talle = new Talle()
            {
                Id = 1,
                Descripcion = "M"
            };
            return talle;
        }

        public static LineaVenta LvFatory2()
        {
            var Lv = new LineaVenta()
            {
                id = 2,
                cantidad = 4,
                ProductoId = ProductFactory().Id,
                Producto = ProductFactory(),
                ColorId = ColorFactory().Id,
                Color = ColorFactory(),
                Talle = TalleFactory(),
                TalleId = TalleFactory().Id,
                VentaId = 1,

            };

            return Lv;


        }

        public static Venta VentaFactory()
        {
            var venta = new Venta()
            {
                id = 1,
                fecha = DateTime.Now,
                LineaVenta = AddLineaVenta(),
                PuntoVentaId = PuntoVentaFactory().id,
                PuntoVenta = PuntoVentaFactory()

            };

            return venta;
        }

        public static Stock StockFactory1()
        {
            var stock = new Stock()
            {
                id = 1,
                cantidad = 20,
                Color = ColorFactory(),
                Talle = TalleFactory(),
                ColorId = ColorFactory().Id,
                TalleId = TalleFactory().Id,
            };

            return stock;
        }
        public static Stock StockFactory2()
        {
            var stock = new Stock()
            {
                id = 1,
                cantidad = 20,
                ColorId = 4,
                TalleId = 5,
            };

            return stock;
        }

        private static List<LineaVenta> AddLineaVenta()
        {
            var Lvs = new List<LineaVenta>();
            Lvs.Add(LvFatory2());
            Lvs.Add(LvFatory1());
            return Lvs;
        }

        private static List<Stock> AddStock()
        {
            var stock = new List<Stock>();
            stock.Add(StockFactory1());
            stock.Add(StockFactory2());
            return stock;
        }


    }
}
