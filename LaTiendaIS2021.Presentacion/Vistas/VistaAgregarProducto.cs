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
    public partial class VistaAgregarProducto : Form, IVistaAgregarProducto
    {
        List<Marca> ListMarca = new List<Marca>();
        List<Rubro> ListRubro = new List<Rubro>();
        PresentadorPrincipal _presentador;
        public VistaAgregarProducto()
        {
            InitializeComponent();
        }

        private  void VistaAgregarProducto_Load(object sender, EventArgs e)
        {
        }
        public async void SetPresentador(PresentadorPrincipal presentador)
        {
            _presentador = presentador;
            bsProducto.DataSource = _presentador.NuevoProducto();
            List<string> marcas = new List<string>();
            List<string> rubros = new List<string>();
            ListMarca = await _presentador.GetMarca();
            ListRubro = await _presentador.GetRubro();

            foreach (var i in ListMarca)
            {
                marcas.Add(i.Descripcion);
            }
            foreach (var i in ListRubro)
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
           
            var oProducto = bsProducto.DataSource as Producto;
            
            oProducto.MarcaId = DevolverIdMarca(cbxMarca.Text);
            
            oProducto.RubroId = DevolverIdRubro(cbxRubro.Text);

            _presentador.AgregarProducto(oProducto);
           
            MessageBox.Show("El Producto se Guardo con Exito");
            bsProducto.Clear();
            Salir();
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

      


        #region Interface

        public void Mostrar(Producto producto= null)
        {
            if(producto == null)
            {
                bsProducto.DataSource = _presentador.NuevoProducto();
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
