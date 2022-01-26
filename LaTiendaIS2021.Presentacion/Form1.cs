
using LaTiendaIS2021.Dominio.Modelo;
using LaTiendaIS2021.Presentacion.Vistas;
using LaTiendaIS2021.Transversal;
using System;
using System.Windows.Forms;

namespace LaTiendaIS2021.Presentacion
{
    public partial class Form1 : Form
    {
        VistaListaProducto AgregrarProducto;
        VistaListaCliente AgregarCliente;
        RealizarVenta Venta;

        PresentadorPrincipal _presentador;
        Usuario User = new Usuario();


        public Form1(PresentadorPrincipal presentador)
        {


            InitializeComponent();
            _presentador = presentador;
            txtPass.PasswordChar = '*';

        }

        public async void Inicializador()
        {
            cbxSucursal.DataSource = await _presentador.GetSucursals();
            cbxSucursal.DisplayMember = "Descripcion";
            cbxSucursal.ValueMember = "Id";


        }
        private void agregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bloquear();
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
            Bloquear();
            if (AgregarCliente == null)
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
            Bloquear();
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bloquear();

            try
            {
                SessionManager.Logout();

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Sucursal suc = new Sucursal();
            PuntoVenta pv = new PuntoVenta();

            suc = (Sucursal)cbxSucursal.SelectedItem;
            pv = (PuntoVenta)cbxPVenta.SelectedItem;


            if (suc.Id != 0 && pv.id != 0)
            {
                try
                {
                    SessionManager.Inicio(suc, pv);
                    SessionManager session = SessionManager.GetInstanceSession;



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            menuStrip1.Enabled = true;
            pnlSucursal.Visible = false;
        }

        private async void cbxSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sucursal suc = (Sucursal)cbxSucursal.SelectedItem;

            var lstPventa = await _presentador.GetPventa(suc.Id);

            cbxPVenta.DataSource = lstPventa;
            cbxPVenta.DisplayMember = "Descripcion";
            cbxPVenta.ValueMember = "Id";



        }

        public void Bloquear()
        {
            label1.Visible = false;
            label2.Visible = false;
            cbxPVenta.Visible = false;
            cbxSucursal.Visible = false;
            btnIngresar.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            User.usuario = txtUser.Text;
            User.contraseña = txtPass.Text;
            int Id = _presentador.BuscarUsuario(User);
            if (Id != 0)
            {
                try
                {
                    User.Id = Id;
                    SessionManager.Login(User);
                    SessionManager session = SessionManager.GetInstanceSession;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            pnlLogin.Visible = false;

            Inicializador();

            pnlSucursal.Visible = true;

           
           


            
        }
    }
}
