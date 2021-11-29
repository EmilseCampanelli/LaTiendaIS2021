using LaTiendaIS2021.Presentacion;
using LaTiendaIS2021.Presentacion.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaTiendaIS2021.Presentacion
{
    public partial class Form1 : Form
    {
        VistaListaProducto AgregrarProducto;
        VistaListaCliente AgregarCliente;
        RealizarVenta Venta;

        PresentadorPrincipal _presentador;

        public Form1(PresentadorPrincipal presentador)
        {
            InitializeComponent();
            _presentador = presentador; 
        }

        private void agregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AgregrarProducto == null)
            {
                AgregrarProducto = new VistaListaProducto(_presentador)
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                };
                AgregrarProducto.VisibleChanged += AgregrarProducto_VisibleChanged;
            }
            menuStrip1.Visible = false;
            AgregrarProducto.Show();
        }

        private void AgregrarProducto_VisibleChanged(object sender, EventArgs e)
        {
            if (AgregrarProducto.Visible) return;
            AgregrarProducto.VisibleChanged -= AgregrarProducto_VisibleChanged;
            AgregrarProducto = null;
            menuStrip1.Visible = true;
        }

        private void agregarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(AgregarCliente == null)
            {
                AgregarCliente = new VistaListaCliente(_presentador)
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                };
                AgregarCliente.VisibleChanged += AgregarCliente_VisibleChanges;
            }
            menuStrip1.Visible = false;
            AgregarCliente.Show();
        }

        private void AgregarCliente_VisibleChanges(object sender, EventArgs e)
        {
            if (AgregarCliente.Visible) return;
            AgregarCliente.VisibleChanged -= AgregarCliente_VisibleChanges;
            AgregarCliente = null;
            menuStrip1.Visible = true;
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Venta == null)
            {
                Venta = new RealizarVenta(_presentador)
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                };
                Venta.VisibleChanged += Venta_VisibleChanged;
            }
            menuStrip1.Visible = false;
            Venta.Show();
        }

        private void Venta_VisibleChanged(object sender, EventArgs e)
        {
            if (Venta.Visible) return;
            Venta.VisibleChanged -= Venta_VisibleChanged;
            Venta = null;
            menuStrip1.Visible = true;
        }
    }
}
