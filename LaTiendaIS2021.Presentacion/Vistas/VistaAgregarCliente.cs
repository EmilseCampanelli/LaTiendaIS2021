using LaTiendaIS2021.Dominio.Modelo;
using LaTiendaIS2021.Presentacion.Interfaces;
using LaTiendaIS2021.Presentacion;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace LaTiendaIS2021.Presentacion.Vistas
{
    public partial class VistaAgregarCliente : Form, IVistaAgregarCliente
    {
        List<CondicionTributaria> ListCondicion = new List<CondicionTributaria>();
        PresentadorPrincipal _presentador;
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

            List<string> condicion = new List<string>();
            foreach (var i in ListCondicion)
            {
                condicion.Add(i.Descripcion);
            }
            comboBox1.DataSource = condicion;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
           
            var oCliente = bsCliente.DataSource as Cliente;
            oCliente.CondicionTributariaId = DevolverIdCondicion(comboBox1.Text);

            _presentador.AgregarCliente(oCliente);


            MessageBox.Show("El Cliente se Guardo con Exito");
            bsCliente.Clear();
            Salir();

        }
        public int DevolverIdCondicion(string descripcion)
        {
            var vs = (from d in ListCondicion
                      where d.Descripcion == descripcion
                      select d.Id).FirstOrDefault();
            return vs;
        }


        #region Interface

        public void Mostrar(Cliente cliente = null)
        {
            if (cliente == null)
            {
                bsCliente.DataSource = new Cliente();
                Agregar();
            }
           
        }

        public void Agregar()
        {
            MostrarPantalla();
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
