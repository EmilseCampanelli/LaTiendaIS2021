using LaTiendaIS2021.Dominio.Modelo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LaTiendaIS2021.Test
{
    [TestClass]
    public class VentaTest
    {

        [TestMethod]
        public void CalcularStock()
        {
            Venta venta = new Venta()
            {
                id = 1,
                ClienteId = 1,
                LineaVenta = RepositorioTest.Datos.lineaVentas,
                PuntoVentaId=1,    
            
            };


            venta.ConfirmarVenta();



        }

    }
}
