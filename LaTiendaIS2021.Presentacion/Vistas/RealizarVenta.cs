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
using System.Windows.Forms;

namespace LaTiendaIS2021.Presentacion.Vistas
{
    public partial class RealizarVenta : Form, IVistaRegistrarVenta
    {
        PresentadorPrincipal _presentador;

        public RealizarVenta(PresentadorPrincipal presentador)
        {
            _presentador = presentador;
            _presentador.setPresentador(this);
            InitializeComponent();
            
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            //Cliente.Mostrar();
            _presentador.AgregarVistaCliente();
        }
        
        private void RealizarVenta_Load(object sender, EventArgs e)
        {

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
           int codigo = int.Parse(txtBuscarProducto.Text);
            Listar(codigo);
        }


        #region Interface

        public async void Listar(int codigo)
        {
            var source = new BindingSource();
            var lst = await _presentador.MostrarProductos();
            source.DataSource = lst;
            dgvLV.DataSource = source;

            DataGridViewComboBoxColumn cbxTalle = new DataGridViewComboBoxColumn();
            cbxTalle = (DataGridViewComboBoxColumn)dgvLV.Columns["Talle"];
            var lst1 = await _presentador.GetTalle();
            foreach (var i in lst1)
            {
                cbxTalle.Items.Add(i.Descripcion);
            }
            //cbxTalle.DisplayMember = "Descripcion";
            //cbxTalle.ValueMember = "Id";
           

           
        }


        #endregion

       
    }
}
