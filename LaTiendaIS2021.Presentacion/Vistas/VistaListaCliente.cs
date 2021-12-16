using LaTiendaIS2021.Presentacion.Interfaces;
using System;
using System.Windows.Forms;

namespace LaTiendaIS2021.Presentacion.Vistas
{
    public partial class VistaListaCliente : Form, IVistaListaCliente
    {
        PresentadorPrincipal _presentador;
        public VistaListaCliente(PresentadorPrincipal presentador)
        {
            _presentador = presentador;
            _presentador.SetPresentadorCliente(this);
            InitializeComponent();


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            _presentador.AgregarVistaCliente();
        }
    }
}
