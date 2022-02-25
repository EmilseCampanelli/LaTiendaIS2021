namespace LaTiendaIs2021.DatosV1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versiof : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ventas", "Conceptos", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ventas", "Conceptos");
        }
    }
}
