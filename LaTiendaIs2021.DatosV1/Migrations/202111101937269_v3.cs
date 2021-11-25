namespace LaTiendaIs2021.DatosV1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LineaVentas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cantidad = c.Int(),
                        precio = c.Decimal(precision: 18, scale: 2),
                        ProductoId = c.Int(nullable: false),
                        VentaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Productoes", t => t.ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.Ventas", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.ProductoId)
                .Index(t => t.VentaId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(),
                        total = c.Decimal(precision: 18, scale: 2),
                        ClienteId = c.Int(nullable: false),
                        PuntoVentaId = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.PuntoVentas", t => t.PuntoVentaId, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.PuntoVentaId)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.PuntoVentas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        descripcion = c.String(),
                        SucursalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Sucursals", t => t.SucursalId, cascadeDelete: true)
                .Index(t => t.SucursalId);
            
            CreateTable(
                "dbo.Sucursals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        usuario = c.String(),
                        contraseña = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Ventas", "PuntoVentaId", "dbo.PuntoVentas");
            DropForeignKey("dbo.PuntoVentas", "SucursalId", "dbo.Sucursals");
            DropForeignKey("dbo.LineaVentas", "VentaId", "dbo.Ventas");
            DropForeignKey("dbo.Ventas", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.LineaVentas", "ProductoId", "dbo.Productoes");
            DropIndex("dbo.PuntoVentas", new[] { "SucursalId" });
            DropIndex("dbo.Ventas", new[] { "UsuarioId" });
            DropIndex("dbo.Ventas", new[] { "PuntoVentaId" });
            DropIndex("dbo.Ventas", new[] { "ClienteId" });
            DropIndex("dbo.LineaVentas", new[] { "VentaId" });
            DropIndex("dbo.LineaVentas", new[] { "ProductoId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Sucursals");
            DropTable("dbo.PuntoVentas");
            DropTable("dbo.Ventas");
            DropTable("dbo.LineaVentas");
        }
    }
}
