using LaTiendaIS2021.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTiendaIS2021.Presentacion.Interfaces
{
    interface IVistaAgregarCliente
    {
        void Mostrar(Cliente cliente = null);
        void Agregar();
        void Modificar(Cliente cliente);
    }
}
