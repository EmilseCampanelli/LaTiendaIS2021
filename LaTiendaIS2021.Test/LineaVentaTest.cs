using LaTiendaIS2021.Dominio.Modelo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LaTiendaIS2021.Test
{
    [TestClass]
    public class LineaVentaTest
    {
        public LineaVentaTest()
        {
           
        }
        LineaVenta lineaVenta;
        [TestMethod]
        public void Linea_De_Venta_Con_Cantidad_De_Producto_Mayor_A_Uno()
        {
            //Configuracion  y Ejecucion
            lineaVenta = new LineaVenta()
            {
                id = 1,
                Producto = RepositorioTest.Datos.BuscarP(1),
                cantidad = 2,
                VentaId = 1

            };


            RepositorioTest.Datos.AgregarLineaVenta(lineaVenta);

            //Comprobacion
            Assert.IsTrue(lineaVenta.CantidadProducto());
            
        }

        [TestMethod]
        public void suma_correcta_al_calcular_subtotal_en_linea_de_venta() 
        {
            //Configuracion y Ejecucion
            lineaVenta = RepositorioTest.Datos.BuscarLV(1);


            var precio = lineaVenta.Producto.PrecioFinal * lineaVenta.cantidad;

            //Ejecucion
            var calculo = lineaVenta.CalcularSubtotal();
            //Comprobacion
            Assert.AreEqual(expected: precio, calculo );
            


        }

        
    }
}
