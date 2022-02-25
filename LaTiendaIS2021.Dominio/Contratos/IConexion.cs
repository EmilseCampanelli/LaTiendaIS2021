using LaTiendaIS2021.Dominio.Modelo;
using LaTiendaIS2021.Dominio.Servicios;

namespace LaTiendaIS2021.Dominio.Contratos
{
    public interface IConexion
    {
        AdapterLogin ConexionLogin();
        AdapterAfipResponse ConexionAfip(AdapterLogin adapter, CabComp cab, DetComp det);

    }
}
