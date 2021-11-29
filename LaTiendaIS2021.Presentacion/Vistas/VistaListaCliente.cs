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
