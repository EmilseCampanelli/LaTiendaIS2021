using LaTiendaIS2021.Dominio.Modelo;
using LaTiendaIS2021.Presentacion.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LaTiendaIS2021.Presentacion.Vistas
{
    public partial class VistaAgregarCliente : Form, IVistaAgregarCliente
    {
        List<CondicionTributaria> ListCondicion = new List<CondicionTributaria>();
        PresentadorPrincipal _presentador;
        Cliente client = new Cliente();
        public VistaAgregarCliente()
        {
            InitializeComponent();
        }

        private void VistaAgregarCliente_Load(object sender, EventArgs e)
        {
        }

        public async void SetPresentador(PresentadorPrincipal presentador)
        {

            _presentador = presentador;
            ListCondicion = await _presentador.GetCondicionAsync();
            bsCliente.DataSource = _presentador.NuevoCliente();


            comboBox1.DataSource = ListCondicion;
            comboBox1.DisplayMember = "Descripcion";
            comboBox1.ValueMember = "Id";
            btnGuardarenVenta.Visible = false;


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var oCliente = bsCliente.DataSource as Cliente;
            CondicionTributaria idCond = (CondicionTributaria)comboBox1.SelectedItem;
            oCliente.CondicionTributariaId = idCond.Id;

            oCliente.CondicionTributaria = idCond;
            client = _presentador.AgregarCliente(oCliente);


            MessageBox.Show("El Cliente se Guardo con Exito");
            bsCliente.Clear();
            Salir();
        }

        private async void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            var cuitClint = txtCuiTCliente.Text;
            Cliente cliente = await _presentador.BuscarClienteAsync(cuitClint);
            if (cliente != null)
            {
                bsCliente.DataSource = cliente;
                condicionTributariaBindingSource.DataSource = cliente.CondicionTributaria;

                client = cliente;
            }

        }

        private void btnGuardarenVenta_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region Interface

        public void Mostrar(int bandera = 0, Cliente cliente = null)
        {
            if (bandera == 1)
            {
                btnGuardarenVenta.Visible = true;
            }

            if (cliente == null)
            {
                bsCliente.DataSource = new Cliente();
                Agregar();
            }
            else
            {

            }


        }

        public void Agregar()
        {
            MostrarPantalla();
        }

        public Cliente MostrarCliente()
        {
            return client;
        }
        #endregion

        #region Utilidades
        public void MostrarPantalla()
        {
            ShowDialog();
        }
        public void Salir()
        {
            Visible = false;
        }




        #endregion


    }
}
