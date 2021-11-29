using LaTiendaIS2021.Dominio.Modelo;
using LaTiendaIS2021.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTiendaIS2021.Presentacion.Interfaces
{
    public interface IVistaAgregarProducto
    {
        void SetPresentador(PresentadorPrincipal presentador);
        void Mostrar(Producto producto = null);
        void Agregar();

    }
}
