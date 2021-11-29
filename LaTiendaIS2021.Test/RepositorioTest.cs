﻿using LaTiendaIS2021.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTiendaIS2021.Test
{
    class RepositorioTest
    {

        public static RepositorioTest Datos = new RepositorioTest();

        List<Producto> productos { get; set; }
        List<LineaVenta> lineaVentas { get; set; }
        List<Venta> ventas { get; set; }
        public RepositorioTest()
        {

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
            foreach(var i in productos)
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