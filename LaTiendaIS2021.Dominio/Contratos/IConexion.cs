using LaTiendaIS2021.Dominio.Servicios;

namespace LaTiendaIS2021.Dominio.Contratos
{
    public interface IConexion
    {
        AdapterLogin ConexionLogin();
        void ConexionAfip(AdapterLogin adapter);

    }
}
