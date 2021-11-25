using LaTiendaIS2021.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTiendaIS2021.Dominio.Contratos
{
    public interface IDatosCliente
    {
        void Agregar(Cliente cliente);
        List<Cliente> GetClientes();
        List<CondicionTributaria> GetCondicion();
    }
}
