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
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace LaTiendaIS2021.Presentacion.Vistas
{
    public partial class VistaAgregarCliente : Form, IVistaAgregarCliente
    {
        List<CondicionTributaria> ListCondicion = new List<CondicionTributaria>();
        public VistaAgregarCliente()
        {
            InitializeComponent();
        }

        private async void VistaAgregarCliente_Load(object sender, EventArgs e)
        {
            List<string> condicion = new List<string>();
            bsCliente.DataSource = new Cliente();

            string res_Condicion = await GetHttpCondicion();
            ListCondicion = JsonConvert.DeserializeObject<List<CondicionTributaria>>(res_Condicion);

            foreach(var i in ListCondicion)
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
            string url = "https://localhost:44332/api/Clientes";
            var oCliente = bsCliente.DataSource as Cliente;
            oCliente.CondicionTributariaId = DevolverIdCondicion(comboBox1.Text);

            string result = Send<Cliente>(url, oCliente, "POST");

            MessageBox.Show("El Cliente se Guardo con Exito");
            bsCliente.Clear();

        }
        public int DevolverIdCondicion(string descripcion)
        {
            var vs = (from d in ListCondicion
                      where d.Descripcion == descripcion
                      select d.Id).FirstOrDefault();
            return vs;
        }

        #region Web Api
        private async Task<string> GetHttpCondicion()
        {
            WebRequest oRequest = WebRequest.Create("https://localhost:44332/api/CondicionTributarias");
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }
       
        public string Send<T>(string url, T objectRequest, string method = "POST")
        {
            string result = ""; //String por la palabra exito
            try
            {


                JavaScriptSerializer js = new JavaScriptSerializer();

                //serializamos el objeto
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest);

                //peticion
                WebRequest request = WebRequest.Create(url);
                //headers
                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8'";
                request.Timeout = 10000; //esto es opcional

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

            }
            catch (Exception e)
            {


                result = e.Message;

            }

            return result;

            
        }
        #endregion

        #region Interface

        public void Mostrar(Cliente cliente = null)
        {
            if (cliente == null)
            {
                bsCliente.DataSource = new Cliente();
                Agregar();
            }
            else
            {
                bsCliente.DataSource = cliente;
                Modificar(cliente);
            }
        }

        public void Agregar()
        {
            MostrarPantalla();
        }

        public void Modificar(Cliente cliente)
        {
            throw new NotImplementedException();
        }
        public void MostrarPantalla()
        {
            ShowDialog();
        }
        #endregion

    }
}
