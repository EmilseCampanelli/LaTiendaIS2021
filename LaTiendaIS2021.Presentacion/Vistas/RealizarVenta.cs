using LaTiendaIS2021.Dominio.Modelo;
using LaTiendaIS2021.Presentacion.Interfaces;
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
    public partial class RealizarVenta : Form
    {
        IVistaAgregarCliente Cliente;
        public RealizarVenta()
        {
            InitializeComponent();
            Cliente = new VistaAgregarCliente();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Cliente.Mostrar();
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
            // Producto producto = new Producto();
            string url = $"https://localhost:44332/api/Productoes/{codigo}";
            string res_Producto = await GetHttpProducto(codigo);
            var producto = JsonConvert.DeserializeObject<Producto>(res_Producto);
            //Inicializar Color Talle 
            productoBindingSource.DataSource = producto;
        }


        #region Api Web
        private async Task<string> GetHttpProducto(int codigo)
        {
            WebRequest oRequest = WebRequest.Create($"https://localhost:44332/api/Productoes/{codigo}");
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }


        #endregion

       
    }
}
