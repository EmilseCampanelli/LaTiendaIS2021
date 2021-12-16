using LaTiendaIS2021.Dominio.Modelo;

namespace LaTiendaIS2021.Presentacion.Interfaces
{
    public interface IVistaAgregarProducto
    {
        void SetPresentador(PresentadorPrincipal presentador);
        void Mostrar(Producto producto = null);
        void Agregar();

    }
}
