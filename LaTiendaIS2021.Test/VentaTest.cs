using LaTiendaIS2021.Dominio.Modelo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LaTiendaIS2021.Test
{
    [TestClass]
    public class VentaTest
    {
        [TestMethod]
        public void agregar_Una_Linea_de_Venta_A_Una_Venta() //Modificar nombre
        {
            //Configuracion o datos
            Venta venta = new Venta();
          

            //Ejecucion

            venta.agregarLineaVenta(RepositorioTest.Datos.BuscarLV(1));

            //Comprobacion
            Assert.IsTrue(venta.ExistenLineasdeVenta());
        }

        [TestMethod]
        public void Suma_Correcta_Precio_Total_De_La_Venta()
        {
            //Configuracion
            Venta venta = new Venta();
           
            venta.agregarLineaVenta(RepositorioTest.Datos.BuscarLV(1));
            venta.agregarLineaVenta(RepositorioTest.Datos.BuscarLV(2));

            //Ejecucion
            
            var calculo = venta.CalcularTotalVenta();

            //Comrobacion
            Assert.AreEqual(expected: 1227600, calculo);

        }
        [TestMethod]
        public void Eliminar_Linea_De_Venta_de_la_Venta()
        {
            //Configuracion
         
            Venta venta = new Venta();
            venta.agregarLineaVenta(RepositorioTest.Datos.BuscarLV(1));

            //Ejecucion
            venta.EliminarLineaVenta(1);

            var lv = RepositorioTest.Datos.BuscarLV(1);
            //Comprobacion
            Assert.IsFalse(venta.BuscarLineaVenta(lv.id));

        }

    }
}
