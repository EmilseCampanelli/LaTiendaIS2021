using LaTiendaIS2021.Dominio.Modelo;
using LaTiendaIS2021.Dominio.Modelo_View;
using LaTiendaIS2021.Presentacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LaTiendaIS2021.Presentacion.Vistas
{
    public partial class Comprobante : Form, IComprobante
    {
        PresentadorPrincipal _presentador;
        List<LineaVenta> Lventas = new List<LineaVenta>();
        Venta Venta = new Venta();
        viewComprobante view = new viewComprobante();
        public Comprobante()
        {
            InitializeComponent();
        }
        public void SetPresentador(PresentadorPrincipal presentador)
        {
            _presentador = presentador;

        }

        public void Mostrar()
        {
            ShowDialog();
        }



        public async void Cliente()
        {
            var client = Venta.Cliente;
            if (client.CondicionTributaria.Letra == "B")
            {
                lblLetraFactura.Text = "B";
                pnlFacturaA.Visible = false;
            }
            txtRazonSocial.Text = client.RazonSocial;
            txtDireccion.Text = client.Domicilio;
            txtLocalidad.Text = client.Domicilio;
            lblCUIT.Text = "CUIT: " + client.Cuit;
            txtCond.Text = client.CondicionTributaria.Descripcion;

        }

        public void Ventainfo()
        {
            txtTotal.Text = Venta.total.ToString();
            var user = _presentador.DevolverUsuario();
            lblUsuario.Text = user.usuario;
            txtFecha.Text = DateTime.Now.ToString();
            var pv = _presentador.DevolverPVenta();
            lblPuntoVenta.Text = pv.descripcion;
            var suc = _presentador.DevolverSucursal();
            lblsucursal.Text = suc.Descripcion;
            txtContado.Text = "Contado";
        }

        public void LineasVenta()
        {
            List<viewComprobante> views = new List<viewComprobante>();
            foreach (var i in Lventas)
            {
                view.Cantidad = (int)i.cantidad;
                view.Descripcion = i.Producto.Descripcion;
                view.PrecioUnitario = i.Producto.PrecioVenta;
                view.Subtotal = (decimal)i.precio;

                views.Add(view);
            }

            var source = new BindingSource();
            source.DataSource = views;

            dgvLV.DataSource = source;
        }

        private void Comprobante_Load(object sender, EventArgs e)
        {
            Lventas = _presentador.ImprimirLV();
            Venta = _presentador.ImprimirVenta();

            Cliente();
            Ventainfo();
            LineasVenta();

        }
    }

}
