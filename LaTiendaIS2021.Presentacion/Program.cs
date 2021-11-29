using LaTiendaIS2021.Presentacion.Interfaces;
using LaTiendaIS2021.Presentacion.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace LaTiendaIS2021.Presentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
          


            var contenedor = new UnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            contenedor.RegisterType<IVistaAgregarProducto, VistaAgregarProducto>();
            contenedor.RegisterType<IVistaAgregarCliente, VistaAgregarCliente>();
            contenedor.RegisterType<IVistaRegistrarVenta, RealizarVenta>();
            contenedor.RegisterType<IVistaListaCliente, VistaListaCliente>();
            contenedor.RegisterType<IVistaListaProducto, VistaListaProducto>();
            var vista = contenedor.Resolve<Form1>();
            Application.Run(vista);
        }
    }
}
