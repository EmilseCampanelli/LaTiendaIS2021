using LaTiendaIS2021.Presentacion.Interfaces;
using LaTiendaIS2021.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaTiendaIS2021.Presentacion.Vistas
{
    public partial class VistaListaProducto : Form, IVistaListaProducto
    {
        PresentadorPrincipal _presentador;
        public VistaListaProducto(PresentadorPrincipal presentador)
        {
            _presentador = presentador;
            _presentador.setPresentadorProducto(this);
            InitializeComponent();
            Listar();
        }

        public async void Listar()
        {
            var source = new BindingSource();
            var lst =  await _presentador.MostrarProductos();
            source.DataSource = lst;
            dgvProducto.DataSource = source;

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _presentador.AgregarVistaProducto();
        }
    }
}
