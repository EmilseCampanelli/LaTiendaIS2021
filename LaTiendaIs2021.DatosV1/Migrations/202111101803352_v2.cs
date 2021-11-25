namespace LaTiendaIs2021.DatosV1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
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
                        CondicionTributariaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CondicionTributarias", t => t.CondicionTributariaId, cascadeDelete: true)
                .Index(t => t.CondicionTributariaId);
            
            CreateTable(
                "dbo.CondicionTributarias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clientes", "CondicionTributariaId", "dbo.CondicionTributarias");
            DropIndex("dbo.Clientes", new[] { "CondicionTributariaId" });
            DropTable("dbo.CondicionTributarias");
            DropTable("dbo.Clientes");
        }
    }
}
