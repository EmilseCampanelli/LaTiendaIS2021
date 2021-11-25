using LaTiendaIS2021.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LaTiendaIS2021.Datos
{
    public class LaTiendaISDB: DbContext
    {
        public LaTiendaISDB() : base("LaTiendaISdb")
        {


        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Color> color { get; set; }
        public DbSet<CondicionTributaria> condicionTributarias { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<LineaVenta> lineaVentas { get; set; }
        public DbSet<Marca> marcas { get; set; }
        public DbSet<Producto> productos { get; set; }
        public DbSet<PuntoVenta> puntoVentas { get; set; }
        public DbSet<Rubro> rubros { get; set; }
        public DbSet<Stock> stocks { get; set; }
        public DbSet<Sucursal> sucursal { get; set; }
        public DbSet<Talle> talles { get; set; }
        public DbSet<TipoEmpleado> tipoEmpleados { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Venta> ventas { get; set; }
    }
}