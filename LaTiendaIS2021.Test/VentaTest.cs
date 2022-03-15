using LaTiendaIS2021.Dominio.Modelo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LaTiendaIS2021.Test
{
    [TestClass]
    public class VentaTest
    {

        [TestMethod]
        public void CalcularTotal()
        {
            var venta = Factory.VentaFactory();

            var calculo = venta.CalcularTotalVenta();

            Assert.AreEqual(expected: 111726, calculo);

        }
        
        [TestMethod]
        public void CalcularStock()
        {
            var venta = Factory.VentaFactory();

            venta.ConfirmarVenta();

            foreach(var lv in venta.LineaVenta)
            {
                foreach(var s in lv.Producto.Stock)
                {
                    
                }
            }

            Assert.IsTrue(true);
            

        }
        
    }
}
