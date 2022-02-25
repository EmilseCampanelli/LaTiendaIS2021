using System.Data.Entity;

namespace LaTiendaIs2021.DatosV1.Data
{
    public class LaTiendaIs2021DatosV1Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public LaTiendaIs2021DatosV1Context() : base("name=LaTiendaIs2021DatosV1Context")
        {
        }

        public System.Data.Entity.DbSet<LaTiendaIS2021.Dominio.Modelo.Producto> Productoes { get; set; }

        public System.Data.Entity.DbSet<LaTiendaIS2021.Dominio.Modelo.Marca> Marcas { get; set; }

        public System.Data.Entity.DbSet<LaTiendaIS2021.Dominio.Modelo.Rubro> Rubroes { get; set; }

        public System.Data.Entity.DbSet<LaTiendaIS2021.Dominio.Modelo.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<LaTiendaIS2021.Dominio.Modelo.CondicionTributaria> CondicionTributarias { get; set; }

        public System.Data.Entity.DbSet<LaTiendaIS2021.Dominio.Modelo.PuntoVenta> PuntoVentas { get; set; }

        public System.Data.Entity.DbSet<LaTiendaIS2021.Dominio.Modelo.Sucursal> Sucursals { get; set; }

        public System.Data.Entity.DbSet<LaTiendaIS2021.Dominio.Modelo.Usuario> Usuarios { get; set; }

        public System.Data.Entity.DbSet<LaTiendaIS2021.Dominio.Modelo.LineaVenta> LineaVentas { get; set; }

        public System.Data.Entity.DbSet<LaTiendaIS2021.Dominio.Modelo.Venta> Ventas { get; set; }

        public System.Data.Entity.DbSet<LaTiendaIS2021.Dominio.Modelo.Color> Colors { get; set; }

        public System.Data.Entity.DbSet<LaTiendaIS2021.Dominio.Modelo.Talle> Talles { get; set; }

        public System.Data.Entity.DbSet<LaTiendaIS2021.Dominio.Modelo.Stock> Stocks { get; set; }

       
    }
}
