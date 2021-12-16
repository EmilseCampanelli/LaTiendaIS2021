using LaTiendaIS2021.Dominio.Modelo;
using System.Collections.Generic;

namespace LaTiendaIS2021.Presentacion.Interfaces
{
    public interface IVistaRegistrarVenta
    {
        Venta MostrarVenta();
        List<LineaVenta> MostrarLVenta();
    }
}
