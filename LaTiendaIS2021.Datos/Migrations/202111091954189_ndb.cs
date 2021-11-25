namespace LaTiendaIS2021.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ndb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cuit = c.String(),
                        RazonSocial = c.String(),
                        Domicilio = c.String(),
                        CondicionTributaria_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CondicionTributarias", t => t.CondicionTributaria_Id)
                .Index(t => t.CondicionTributaria_Id);
            
            CreateTable(
                "dbo.CondicionTributarias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(),
                        total = c.Decimal(precision: 18, scale: 2),
                        Cliente_Id = c.Int(),
                        PuntoVenta_id = c.Int(),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id)
                .ForeignKey("dbo.PuntoVentas", t => t.PuntoVenta_id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.Cliente_Id)
                .Index(t => t.PuntoVenta_id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.LineaVentas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cantidad = c.Int(),
                        precio = c.Decimal(precision: 18, scale: 2),
                        Producto_Id = c.Int(),
                        Venta_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Productoes", t => t.Producto_Id)
                .ForeignKey("dbo.Ventas", t => t.Venta_id)
                .Index(t => t.Producto_Id)
                .Index(t => t.Venta_id);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(),
                        Descripcion = c.String(),
                        CostoSinIva = c.Decimal(precision: 18, scale: 2),
                        PorcentajeIva = c.Decimal(precision: 18, scale: 2),
                        MargenGanancia = c.Decimal(precision: 18, scale: 2),
                        PrecioFinal = c.Decimal(precision: 18, scale: 2),
                        Marca_Id = c.Int(),
                        Rubro_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.Marca_Id)
                .ForeignKey("dbo.Rubroes", t => t.Rubro_Id)
                .Index(t => t.Marca_Id)
                .Index(t => t.Rubro_Id);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rubroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cantidad = c.Int(),
                        Color_Id = c.Int(),
                        Producto_Id = c.Int(),
                        Sucursal_Id = c.Int(),
                        Talle_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Colors", t => t.Color_Id)
                .ForeignKey("dbo.Productoes", t => t.Producto_Id)
                .ForeignKey("dbo.Sucursals", t => t.Sucursal_Id)
                .ForeignKey("dbo.Talles", t => t.Talle_Id)
                .Index(t => t.Color_Id)
                .Index(t => t.Producto_Id)
                .Index(t => t.Sucursal_Id)
                .Index(t => t.Talle_Id);
            
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sucursals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Talles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PuntoVentas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descripcion = c.String(),
                        Sucursal_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Sucursals", t => t.Sucursal_Id)
                .Index(t => t.Sucursal_Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        usuario = c.String(),
                        contraseña = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dni = c.Int(),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Telefono = c.String(),
                        Domicilio = c.String(),
                        TipoEmpleado_Id = c.Int(),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoEmpleadoes", t => t.TipoEmpleado_Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.TipoEmpleado_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.TipoEmpleadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Empleadoes", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Empleadoes", "TipoEmpleado_Id", "dbo.TipoEmpleadoes");
            DropForeignKey("dbo.Ventas", "PuntoVenta_id", "dbo.PuntoVentas");
            DropForeignKey("dbo.PuntoVentas", "Sucursal_Id", "dbo.Sucursals");
            DropForeignKey("dbo.LineaVentas", "Venta_id", "dbo.Ventas");
            DropForeignKey("dbo.Stocks", "Talle_Id", "dbo.Talles");
            DropForeignKey("dbo.Stocks", "Sucursal_Id", "dbo.Sucursals");
            DropForeignKey("dbo.Stocks", "Producto_Id", "dbo.Productoes");
            DropForeignKey("dbo.Stocks", "Color_Id", "dbo.Colors");
            DropForeignKey("dbo.Productoes", "Rubro_Id", "dbo.Rubroes");
            DropForeignKey("dbo.Productoes", "Marca_Id", "dbo.Marcas");
            DropForeignKey("dbo.LineaVentas", "Producto_Id", "dbo.Productoes");
            DropForeignKey("dbo.Ventas", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.Clientes", "CondicionTributaria_Id", "dbo.CondicionTributarias");
            DropIndex("dbo.Empleadoes", new[] { "Usuario_Id" });
            DropIndex("dbo.Empleadoes", new[] { "TipoEmpleado_Id" });
            DropIndex("dbo.PuntoVentas", new[] { "Sucursal_Id" });
            DropIndex("dbo.Stocks", new[] { "Talle_Id" });
            DropIndex("dbo.Stocks", new[] { "Sucursal_Id" });
            DropIndex("dbo.Stocks", new[] { "Producto_Id" });
            DropIndex("dbo.Stocks", new[] { "Color_Id" });
            DropIndex("dbo.Productoes", new[] { "Rubro_Id" });
            DropIndex("dbo.Productoes", new[] { "Marca_Id" });
            DropIndex("dbo.LineaVentas", new[] { "Venta_id" });
            DropIndex("dbo.LineaVentas", new[] { "Producto_Id" });
            DropIndex("dbo.Ventas", new[] { "Usuario_Id" });
            DropIndex("dbo.Ventas", new[] { "PuntoVenta_id" });
            DropIndex("dbo.Ventas", new[] { "Cliente_Id" });
            DropIndex("dbo.Clientes", new[] { "CondicionTributaria_Id" });
            DropTable("dbo.TipoEmpleadoes");
            DropTable("dbo.Empleadoes");
            DropTable("dbo.Usuarios");
            DropTable("dbo.PuntoVentas");
            DropTable("dbo.Talles");
            DropTable("dbo.Sucursals");
            DropTable("dbo.Colors");
            DropTable("dbo.Stocks");
            DropTable("dbo.Rubroes");
            DropTable("dbo.Marcas");
            DropTable("dbo.Productoes");
            DropTable("dbo.LineaVentas");
            DropTable("dbo.Ventas");
            DropTable("dbo.CondicionTributarias");
            DropTable("dbo.Clientes");
        }
    }
}
