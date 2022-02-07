using LaTiendaIS2021.Dominio.Modelo;
using System.Collections.Generic;

namespace LaTiendaIS2021.Test
{
    class RepositorioTest
    {

        public static RepositorioTest Datos = new RepositorioTest();

        List<Producto> productos { get; set; }
        public List<LineaVenta> lineaVentas { get; set; }
        public List<Venta> ventas { get; set; }

        public List<Stock> stocks { get; set; }
        public RepositorioTest()
        {
            stocks = new List<Stock>()
            {
                new Stock()
                {
                    id=1,
                    cantidad= 20,
                    ColorId=1,
                    ProductoId=1,
                    SucursalId=1,
                    TalleId=1
                },
                new Stock()
                {
                    id=1,
                    cantidad= 20,
                    ColorId=2,
                    ProductoId=1,
                    SucursalId=1,
                    TalleId=1
                },
                new Stock()
                {
                    id=1,
                    cantidad= 20,
                    ColorId=1,
                    ProductoId=1,
                    SucursalId=1,
                    TalleId=2
                },
                new Stock()
                {
                    id=1,
                    cantidad= 20,
                    ColorId=1,
                    ProductoId=2,
                    SucursalId=1,
                    TalleId=1
                },
            };

            productos = new List<Producto>()
            {
                new Producto()
                {
                    Id = 1,
                    Codigo = 1,
                    Descripcion = "Jean",
                    CostoSinIva = 300,
                    MargenGanancia = 30,
                    PorcentajeIva = 21,
                    MarcaId = 1,
                    RubroId = 1
                },
                 new Producto()
                {
                    Id = 1,
                    Codigo = 2,
                    Descripcion = "Jean",
                    CostoSinIva = 300,
                    MargenGanancia = 30,
                    PorcentajeIva = 21,
                    MarcaId = 1,
                    RubroId = 1
                }
             };

            lineaVentas = new List<LineaVenta>()
            {
                new LineaVenta()
                {
                    id=1,
                    ProductoId=1,
                    Producto= BuscarP(1),
                    cantidad= 2,
                    VentaId=1,
                },
                new LineaVenta()
                {
                    id=2,
                    ProductoId=1,
                    Producto= BuscarP(1),
                    cantidad= 4,
                    VentaId=1,
                }
            };

            ventas = new List<Venta>();
        }

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public Producto BuscarP(int codigo)
        {
            foreach (var i in productos)
            {
                if (codigo == i.Codigo) return i;
            }
            return null;
        }

        public void AgregarLineaVenta(LineaVenta lineaVenta)
        {
            lineaVentas.Add(lineaVenta);
        }

        public LineaVenta BuscarLV(int id)
        {
            foreach (var i in lineaVentas)
            {
                if (id == i.id) return i;
            }
            return null;
        }

        public void AgregarVenta(Venta venta)
        {
            ventas.Add(venta);
        }
    }
}
