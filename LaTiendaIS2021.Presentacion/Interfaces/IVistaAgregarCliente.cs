using LaTiendaIS2021.Dominio.Modelo;

namespace LaTiendaIS2021.Presentacion.Interfaces
{
    public interface IVistaAgregarCliente
    {
        void SetPresentador(PresentadorPrincipal presentador);
        void Agregar();
        void Mostrar(int bandera = 0, Cliente cliente = null);
        Cliente MostrarCliente();
    }
}
