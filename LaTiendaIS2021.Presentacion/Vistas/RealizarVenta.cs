using LaTiendaIS2021.Dominio.Modelo;
using LaTiendaIS2021.Dominio.Servicios;
using LaTiendaIS2021.Presentacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LaTiendaIS2021.Presentacion.Vistas
{
    public partial class RealizarVenta : Form, IVistaRegistrarVenta
    {
        PresentadorPrincipal _presentador;
        List<Stock> lstStocks = new List<Stock>();
        List<Producto> lstProd = new List<Producto>();
        LineaVenta _lv = new LineaVenta();
        List<LineaVenta> lstLineaVenta = new List<LineaVenta>();
        Venta Venta = new Venta();
        Cliente cliente = new Cliente();
        AdapterLogin adapter = new AdapterLogin();
        public RealizarVenta(PresentadorPrincipal presentador)
        {
            _presentador = presentador;
            _presentador.setPresentador(this);
            InitializeComponent();
            new Venta();
            productoBindingSource.DataSource = new Producto();
            var user = _presentador.DevolverUsuario();
            var suc = _presentador.DevolverSucursal();
            var punt = _presentador.DevolverPVenta();
            lblUsuario.Text = "Usuario: " + user.usuario;
            lblPuntoVenta.Text = "Sucursal: " + suc.Descripcion + " " + "Punto de venta: " + punt.descripcion;


        }



        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            _presentador.AgregarVistaCliente(1);
            pnlCliente.Visible = true;
            cliente = _presentador.MostrarCliente();
            if (cliente != null)
            {
                lblCuit.Text = cliente.Cuit;
                lblRazonSocial.Text = cliente.RazonSocial;
                lblCondicionTributaria.Text = cliente.CondicionTributaria.Descripcion;
            }
            else MessageBox.Show("No se ha seleccionado ningun Cliente");


        }

        private void RealizarVenta_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtBuscarProducto.Text);
            Listar(codigo);
            ListarStock(codigo);

        }
        private async void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
           
                adapter = _presentador.GetAdapterLogin();
            // _presentador.IngresarAFIP(adapter);
            if (adapter != null)
            {

            }
            else { MessageBox.Show("Algo Fallo"); }
                if (true)
                {
                    if (cliente.Id == 0)
                    {
                        cliente = await _presentador.BuscarClienteAsync("1");
                    }


                    Venta = _presentador.GuardarVenta(DevolverVenta());

                    if (Venta == null)
                    {
                        MessageBox.Show("Usted debe agregar un cliente");
                        btnAgregarCliente_Click(sender, e);
                        Venta = _presentador.GuardarVenta(DevolverVenta());
                    }
                }
                
          
           

          /* foreach (var l in lstLineaVenta)
            {
                l.VentaId = Venta.id;
                _presentador.GuardarLineaVenta(l);
            }

            _presentador.GenerarComprobante();*/

        }

        #region Interface

        public Venta MostrarVenta()
        {
            return Venta;
        }
        public List<LineaVenta> MostrarLVenta()
        {
            return lstLineaVenta;
        }
        public Venta DevolverVenta()
        {
            Venta venta = new Venta();
            venta.fecha = DateTime.Now;
            venta.total = decimal.Parse(txtTotal.Text);
            venta.Cliente = cliente;
            venta.ClienteId = cliente.Id;
            venta.PuntoVenta = _presentador.DevolverPVenta();
            venta.PuntoVentaId = venta.PuntoVenta.id;
            venta.Usuario = _presentador.DevolverUsuario();
            venta.UsuarioId = venta.Usuario.Id;
            venta.LineaVenta = lstLineaVenta;

            return venta;
        }
        public async void Listar(int codigo)
        {
            var prod = await _presentador.MostrarProductos(codigo);
            lstProd.Add(prod.First());

            productoBindingSource.ResetBindings(true);
            productoBindingSource.DataSource = lstProd;
        }
        public async void ListarStock(int codigo)
        {
            List<Talle> talles = new List<Talle>();
            List<Dominio.Modelo.Color> colors = new List<Dominio.Modelo.Color>();
            lstStocks = await _presentador.ListarStocks(codigo);

            foreach (var i in lstStocks)
            {
                talles.Add(i.Talle);
                colors.Add(i.Color);
            }

            ListarCbx(talles, colors);
        }

        public void ListarCbx(List<Talle> talles, List<Dominio.Modelo.Color> colors)
        {
            List<Talle> auxTail = new List<Talle>();
            List<Dominio.Modelo.Color> auxColor = new List<Dominio.Modelo.Color>();
            foreach (var i in talles)
            {
                if (!auxTail.Any(t => t.Descripcion == i.Descripcion))
                {
                    auxTail.Add(i);
                }
            }
            foreach (var i in colors)
            {
                if (!auxColor.Any(c => c.Descripcion == i.Descripcion))
                {
                    auxColor.Add(i);
                }
            }

            cbxTalle.DataSource = auxTail;
            cbxTalle.DisplayMember = "Descripcion";
            cbxTalle.ValueMember = "Id";
            cbxColor.DataSource = auxColor;
            cbxColor.DisplayMember = "Descripcion";
            cbxColor.ValueMember = "Id";
        }

        public void Listar(int? codProd)
        {

            ListarStock((int)codProd);
        }

        public void AgregarLV()
        {
            _lv.Producto = productoBindingSource.Current as Producto;
            _lv.ProductoId = _lv.Producto.Id;
            _lv.cantidad = (int?)NudCantidad.Value;
            _lv.Color = cbxColor.SelectedItem as Dominio.Modelo.Color;
            _lv.ColorId = _lv.Color.Id;
            _lv.Talle = cbxTalle.SelectedItem as Talle;
            _lv.TalleId = _lv.Talle.Id;

        }

        public void EliminarLV(LineaVenta lv)
        {
            _presentador.EliminarLineaVenta(lv);
        }



        #endregion



        private void dgvLV_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = productoBindingSource.Current as Producto;

                Listar(producto.Codigo);
            }
            catch
            {
                MessageBox.Show("No se ha seleccionado ningun producto");
            }


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarLV();
            if (!lstLineaVenta.Any(l => l.ProductoId == _lv.ProductoId))
            {
                _presentador.AgregarLineaVenta(_lv);

                _lv = new LineaVenta();
            }
            else
            {
                if (_presentador.VerificarLv(_lv) == 1)
                {

                    EliminarLV(_presentador.BuscarLv(_lv.ProductoId));

                }
                _presentador.AgregarLineaVenta(_lv);
                _lv = new LineaVenta();
            }

            lstLineaVenta = _presentador.MostrarLineaVenta();
            ActualizarTotal();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            AgregarLV();
            var lv = lstLineaVenta.Find(l => l.ProductoId == _lv.ProductoId && l.TalleId == _lv.TalleId && l.ColorId == _lv.ColorId);
            EliminarLV(lv);
            _lv = new LineaVenta();
            lstLineaVenta = _presentador.MostrarLineaVenta();
            ActualizarTotal();
        }

        public void ActualizarTotal()
        {
            txtTotal.Text = _presentador.ActualizarTotalVenta().ToString();
        }


    }
}
