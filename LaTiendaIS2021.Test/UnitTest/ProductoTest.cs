using LaTiendaIS2021.Dominio.Modelo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LaTiendaIS2021.Test
{
    [TestClass]
    public class ProductoTest
    {

        [TestMethod]
        public void CrearUnNuevoProductoyCalcularNetoGravadoCorrectamente()
        {
            var producto = Factory.ProductFactory();
            decimal costo = producto.CostoConIva;
            decimal mdg = producto.MargenGanancia;

            var netogravadoEsperado = 9300;
            decimal NetoGravado = producto.NetoGravado;

            Assert.AreEqual(netogravadoEsperado, NetoGravado);
        }
    }
}
