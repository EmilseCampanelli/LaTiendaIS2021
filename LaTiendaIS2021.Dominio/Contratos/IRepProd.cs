using LaTiendaIS2021.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTiendaIS2021.Dominio.Contratos
{
    public interface IRepProd
    {
        void Agregar(Producto producto);
        void Eliminar(int codProd);
        void Modificar(int codProd);
        List<Producto> Listar();
        List<Producto> Filtrar(string descripcion);
        Producto Buscar(int codProd);

        List<Marca> ListarMarcas();
        List<Rubro> ListarRubros();
    }
}
