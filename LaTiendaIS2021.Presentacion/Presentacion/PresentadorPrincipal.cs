using LaTiendaIs2021.DatosV1.Models;
using LaTiendaIS2021.Dominio.Modelo;
using LaTiendaIS2021.Dominio.Modelo_View;
using LaTiendaIS2021.Presentacion.Interfaces;
using LaTiendaIS2021.Presentacion.Vistas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTiendaIS2021.Presentacion
{
    public class PresentadorPrincipal
    {
        IVistaAgregarCliente _VistaCliente;
        IVistaAgregarProducto _VistaProducto;
        IVistaRegistrarVenta _VistaVenta;
        IVistaListaCliente _ListaCliente;
        IVistaListaProducto _ListaProducto;
        public PresentadorPrincipal(IVistaAgregarProducto agregarProducto, IVistaAgregarCliente agregarCliente)
        {
            _VistaCliente = agregarCliente;
            _VistaCliente.SetPresentador(this);
            _VistaProducto = agregarProducto;
            _VistaProducto.SetPresentador(this);

        }

        #region Inicializacion

        public void setPresentadorProducto(IVistaListaProducto vistaListaProducto)
        {
            _ListaProducto = vistaListaProducto;
        }

        public void  SetPresentadorCliente(IVistaListaCliente vistaListaCliente)
        {
            _ListaCliente = vistaListaCliente;
        }

        public void setPresentador(IVistaRegistrarVenta venta)
        {
            _VistaVenta = venta;
        }
        #endregion

        #region Nuevo
        public Cliente NuevoCliente()
        {
            return new Cliente();
        }
        public Producto NuevoProducto()
        {
            return new Producto();
        }
        #endregion

        #region Api Web
        public async Task<List<CondicionTributaria>> GetCondicionAsync()
        {
            List<CondicionTributaria> lst = new List<CondicionTributaria>();
            string url = "https://localhost:44332/api/CondicionTributarias";
            string res_Condicion = await ConsultaApi.GetHttp(url);
            lst = JsonConvert.DeserializeObject<List<CondicionTributaria>>(res_Condicion);
            return lst;
        }

        public async Task<List<Marca>> GetMarca()
        {
            string url = "https://localhost:44332/api/Marcas";
            string res_Marca = await ConsultaApi.GetHttp(url);
            return JsonConvert.DeserializeObject<List<Marca>>(res_Marca);
        }

        public async Task<List<Rubro>> GetRubro()
        {
            string url = "https://localhost:44332/api/Rubroes";
            string res_Rubro = await ConsultaApi.GetHttp(url);
            return JsonConvert.DeserializeObject<List<Rubro>>(res_Rubro);
        }
        #endregion


        #region Producto
        public void AgregarProducto(Producto producto)
        {
            string url = "https://localhost:44332/api/Productoes";
            string result = ConsultaApi.Send<Producto>(url, producto, "POST");
        }
        public void AgregarVistaProducto()
        {
            _VistaProducto.Mostrar();
        }

        public async Task<List<viewProductos>> MostrarProductos()
        {
            List<Producto> lst = new List<Producto>();
            string url = "https://localhost:44332/api/viewProductos";
            string res_Prod = await ConsultaApi.GetHttp(url);
           return JsonConvert.DeserializeObject<List<viewProductos>>(res_Prod);
          

        }
        #endregion

        #region Cliente
        public void AgregarCliente(Cliente cliente)
        {
            string url = "https://localhost:44332/api/Clientes";
            string result = ConsultaApi.Send<Cliente>(url, cliente, "POST");
        }
        public void AgregarVistaCliente()
        {
            _VistaCliente.Mostrar();
        }
        #endregion

        #region Venta
        public async Task<List<Talle>> GetTalle()
        {
            List<Producto> lst = new List<Producto>();
            string url = "https://localhost:44332/api/Talles";
            string res_Prod = await ConsultaApi.GetHttp(url);
            return JsonConvert.DeserializeObject<List<Talle>>(res_Prod);
        }
        #endregion

    }
}
