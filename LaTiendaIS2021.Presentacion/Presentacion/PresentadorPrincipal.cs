using LaTiendaIs2021.DatosV1.Models;
using LaTiendaIS2021.Dominio.Contratos;
using LaTiendaIS2021.Dominio.Modelo;
using LaTiendaIS2021.Dominio.Servicios;
using LaTiendaIS2021.Presentacion.Interfaces;
using LaTiendaIS2021.Transversal;
using Newtonsoft.Json;
using System.Collections.Generic;
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
        IComprobante _Comprobante;
        IConexion _WDS;

        Venta Venta;
        public PresentadorPrincipal(IVistaAgregarProducto agregarProducto, IVistaAgregarCliente agregarCliente, IComprobante comprobante, IConexion conexion)
        {
            _VistaCliente = agregarCliente;
            _VistaCliente.SetPresentador(this);
            _VistaProducto = agregarProducto;
            _VistaProducto.SetPresentador(this);
            _Comprobante = comprobante;
            _Comprobante.SetPresentador(this);
            _WDS = conexion;
        }

        #region Inicializacion

        public void setPresentadorProducto(IVistaListaProducto vistaListaProducto)
        {
            _ListaProducto = vistaListaProducto;
        }

        public void SetPresentadorCliente(IVistaListaCliente vistaListaCliente)
        {
            _ListaCliente = vistaListaCliente;
        }

        public void setPresentador(IVistaRegistrarVenta venta)
        {
            _VistaVenta = venta;
            Venta = new Venta();
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
        public Usuario NuevoUsuario()
        {
            return new Usuario();
        }


        #endregion

        #region Api Web
        public async Task<List<Sucursal>> GetSucursals()
        {
            List<Sucursal> lst = new List<Sucursal>();
            string url = "https://localhost:44332/api/Sucursals";
            string res_suc = await ConsultaApi.GetHttp(url);
            lst = JsonConvert.DeserializeObject<List<Sucursal>>(res_suc);
            return lst;
        }
        public async Task<List<PuntoVenta>> GetPventa(int sucursal)
        {
            List<PuntoVenta> lst = new List<PuntoVenta>();
            string url = $"https://localhost:44332/api/PuntoVentas?suc={sucursal}";

            string res_pv = await ConsultaApi.GetHttp(url);
            lst = JsonConvert.DeserializeObject<List<PuntoVenta>>(res_pv);
            return lst;
        }
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
        public async Task<List<Talle>> GetTalle()
        {
            List<Producto> lst = new List<Producto>();
            string url = "https://localhost:44332/api/Talles";
            string res_Prod = await ConsultaApi.GetHttp(url);
            return JsonConvert.DeserializeObject<List<Talle>>(res_Prod);
        }

        public async Task<List<Stock>> ListarStocks(int codigoProd)
        {
            string url = $"https://localhost:44332/api/Stocks?codProd={codigoProd}";
            string res_Stock = await ConsultaApi.GetHttp(url);
            return JsonConvert.DeserializeObject<List<Stock>>(res_Stock);
        }

        public async Task<List<Producto>> MostrarProductos(int codigo = 0)
        {
            string url = "";
            if (codigo == 0)
            {
                url = "https://localhost:44332/api/Productoes";
            }
            else
            {
                url = $"https://localhost:44332/api/Productoes?codProd={codigo}";

            }
            List<Producto> lst = new List<Producto>();

            string res_Prod = await ConsultaApi.GetHttp(url);
            return JsonConvert.DeserializeObject<List<Producto>>(res_Prod);


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


        #endregion

        #region Cliente
        public Cliente AgregarCliente(Cliente cliente)
        {
            string url = "https://localhost:44332/api/Clientes";
            string result = ConsultaApi.Send<Cliente>(url, cliente, "POST");
            return JsonConvert.DeserializeObject<Cliente>(result);
        }
        public void AgregarVistaCliente(int bandera = 0)
        {
            _VistaCliente.Mostrar(bandera);
        }

        public async Task<Cliente> BuscarClienteAsync(string cuit)
        {
            string url = $"https://localhost:44332/api/Clientes?cuit={cuit}";
            string result = await ConsultaApi.GetHttp(url);
            return JsonConvert.DeserializeObject<Cliente>(result);

        }

        public Cliente MostrarCliente()
        {
            return _VistaCliente.MostrarCliente();
        }
        #endregion

        #region Venta
        public Venta GuardarVenta(Venta venta)
        {

            if (venta.total > 10000 && venta.Cliente.Cuit == "1")
            {
                return null;
            }
            else
            {
                string url = "https://localhost:44332/api/Ventas";
                string result = ConsultaApi.Send<Venta>(url, venta, "POST");
                return JsonConvert.DeserializeObject<Venta>(result);
            }

        }
        public void GuardarLineaVenta(LineaVenta Lventa)
        {
            DescontarStock(Lventa);
            string url = "https://localhost:44332/api/LineaVentas";
            string result = ConsultaApi.Send<LineaVenta>(url, Lventa, "POST");
        }

        public void DescontarStock(LineaVenta lVenta)
        {
            var stock = new Stock();
            stock.ProductoId = lVenta.ProductoId;
            stock.TalleId = lVenta.TalleId;
            stock.ColorId = lVenta.ColorId;
            stock.cantidad = lVenta.cantidad;

            
        }
        public void AgregarLineaVenta(LineaVenta Lventa)
        {
           // Venta.agregarLineaVenta(Lventa);
            Venta.LineaVenta.Add(Lventa);

        }

        public List<LineaVenta> MostrarLineaVenta()
        {
            return (List<LineaVenta>)Venta.LineaVenta;
        }

        public void EliminarLineaVenta(LineaVenta Lventa)
        {

            var b = Venta.LineaVenta.Remove(Lventa);

        }

        public int VerificarLv(LineaVenta Lventa)
        {
            foreach (var i in Venta.LineaVenta)
            {
                if (i.ProductoId == Lventa.ProductoId && i.TalleId == Lventa.TalleId && i.ColorId == Lventa.ColorId)
                {
                    return 1;
                }

            }
            return 0;
        }
        public LineaVenta BuscarLv(int codProd)
        {
            foreach (var i in Venta.LineaVenta)
            {
                if (i.ProductoId == codProd)
                {
                    return i;
                }
            }
            return null;
        }

        public decimal ActualizarTotalVenta()
        {
            return Venta.CalcularTotalVenta();
        }
        #endregion

        #region Usuario
        public int BuscarUsuario(Usuario user)
        {
            string url = "https://localhost:44332/api/Usuarios";
            string var = ConsultaApi.Send<Usuario>(url, user, "POST");
            return int.Parse(var);
        }
        public Usuario DevolverUsuario()
        {
            SessionManager session = SessionManager.GetInstanceSession;
            return session.usuario;
        }

        public Sucursal DevolverSucursal()
        {
            SessionManager session = SessionManager.GetInstanceSession;
            return session.Sucursal;
        }

        public PuntoVenta DevolverPVenta()
        {
            SessionManager session = SessionManager.GetInstanceSession;
            return session.PuntoVenta;
        }
        #endregion

        #region Comprobante
        public void GenerarComprobante()
        {
            _Comprobante.Mostrar();
        }

        public List<LineaVenta> ImprimirLV()
        {
            return _VistaVenta.MostrarLVenta();
        }

        public Venta ImprimirVenta()
        {
            return _VistaVenta.MostrarVenta();
        }

        #endregion


        #region Conexion
        public AdapterLogin GetAdapterLogin()
        {
            return _WDS.ConexionLogin();
        }
        public void IngresarAFIP(AdapterLogin adapter)
        {
            AccesoExterno.WSAfip.ServiceSoapClient service = new AccesoExterno.WSAfip.ServiceSoapClient();
            service.FEDummy();
            AccesoExterno.WSAfip.FEAuthRequest auth = new AccesoExterno.WSAfip.FEAuthRequest();
            auth.Cuit = adapter.Cuit;
            auth.Sign = adapter.Sing;
            auth.Token = adapter.Token;
            var ser = service.FECAESolicitar(auth, new AccesoExterno.WSAfip.FECAERequest());

        }

        #endregion

    }
}
