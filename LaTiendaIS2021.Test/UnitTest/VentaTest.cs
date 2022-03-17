using LaTiendaIS2021.Dominio.Modelo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LaTiendaIS2021.Test
{
    [TestClass]
    public class VentaTest
    {

        [TestMethod]
        public void CalculoDeTotalDeLaVenta()
        {
            var venta = Factory.VentaFactory();

            var calculo = venta.CalcularTotalVenta();

            Assert.AreEqual(expected: 111726, calculo);

        }
   
        
    }
}
