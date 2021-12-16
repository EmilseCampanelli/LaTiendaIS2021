using LaTiendaIS2021.Dominio.Modelo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LaTiendaIS2021.Test
{
    [TestClass]
    class ProductoTest
    {

        public void agregar_Nuevo_Producto()
        {
            Producto producto = new Producto()
            {
                Id = 1,
                Codigo = 1,
                Descripcion = "Jean",
                CostoSinIva = 300,
                MargenGanancia = 30,
                PorcentajeIva = 21,
                MarcaId = 1,
                RubroId = 1
            };
            RepositorioTest.Datos.AgregarProducto(producto);

        }
    }
}
