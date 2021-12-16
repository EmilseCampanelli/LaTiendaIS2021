using LaTiendaIS2021.Dominio.Modelo;
using LaTiendaIS2021.Presentacion.Interfaces;
using System;
using System.Collections.Generic;
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

        private void VistaAgregarProducto_Load(object sender, EventArgs e)
        {
        }
        public async void SetPresentador(PresentadorPrincipal presentador)
        {
            _presentador = presentador;
            bsProducto.DataSource = _presentador.NuevoProducto();

            ListMarca = await _presentador.GetMarca();
            ListRubro = await _presentador.GetRubro();

            cbxMarca.DataSource = ListMarca;
            cbxMarca.DisplayMember = "Descripcion";
            cbxMarca.ValueMember = "Id";

            cbxRubro.DataSource = ListRubro;
            cbxRubro.DisplayMember = "Descripcion";
            cbxRubro.ValueMember = "Id";


        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {

            var oProducto = bsProducto.DataSource as Producto;
            var idMarca = (Marca)cbxMarca.SelectedItem;
            var idRubro = (Rubro)cbxRubro.SelectedItem;

            oProducto.MarcaId = idMarca.Id;

            oProducto.RubroId = idRubro.Id;

            _presentador.AgregarProducto(oProducto);

            MessageBox.Show("El Producto se Guardo con Exito");
            bsProducto.Clear();
            Salir();
        }




        #region Interface

        public void Mostrar(Producto producto = null)
        {
            if (producto == null)
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
