using LaTiendaIS2021.Dominio.Modelo;
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
    public partial class VistaAgregarProducto : Form
    {
        List<Marca> ListMarca = new List<Marca>();
        List<Rubro> ListRubro = new List<Rubro>();
        public VistaAgregarProducto()
        {
            InitializeComponent();
        }

        private async void VistaAgregarProducto_Load(object sender, EventArgs e)
        {
            List<string> marcas = new List<string>();
            List<string> rubros = new List<string>();
            bsProducto.DataSource = new Producto();

            string res_Marca = await GetHttpMarca();
           ListMarca = JsonConvert.DeserializeObject<List<Marca>>(res_Marca);

            string res_Rubro = await GetHttpRubro();
            ListRubro = JsonConvert.DeserializeObject<List<Rubro>>(res_Rubro);

            foreach(var i in ListMarca)
            {
                marcas.Add(i.Descripcion);
            }
            foreach(var i in ListRubro)
            {
                rubros.Add(i.Descripcion);
            }

            cbxMarca.DataSource = marcas;
            cbxRubro.DataSource = rubros;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:44332/api/Productoes";
            var oProducto = bsProducto.DataSource as Producto;
            
            oProducto.MarcaId = DevolverIdMarca(cbxMarca.Text);
            
            oProducto.RubroId = DevolverIdRubro(cbxRubro.Text);
          
            string result = Send<Producto>(url, oProducto, "POST");
            MessageBox.Show("El Producto se Guardo con Exito");
            bsProducto.Clear();
        }

        public int DevolverIdMarca(string descripcion)
        {
            var vs = (from d in ListMarca
                      where d.Descripcion == descripcion
                      select d.Id).FirstOrDefault();
            return vs;
        }
        public int DevolverIdRubro(string descripcion)
        {
            var vs = (from d in ListRubro
                      where d.Descripcion == descripcion
                      select d.Id).FirstOrDefault();

            return vs;
        }

        #region Web Api
        private async Task<string> GetHttpMarca()
        {
            WebRequest oRequest = WebRequest.Create("https://localhost:44332/api/Marcas");
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }
        private async Task<string> GetHttpRubro()
        {
            WebRequest oRequest = WebRequest.Create("https://localhost:44332/api/Rubroes");
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
    }
}
