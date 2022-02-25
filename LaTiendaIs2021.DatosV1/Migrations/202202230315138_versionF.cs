namespace LaTiendaIs2021.DatosV1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versionF : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ventas", "CondicionTributariaId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ventas", "CondicionTributariaId");
        }
    }
}
