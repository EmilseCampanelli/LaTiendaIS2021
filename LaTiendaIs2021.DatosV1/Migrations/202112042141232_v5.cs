namespace LaTiendaIs2021.DatosV1.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LineaVentas", "TalleId", c => c.Int(nullable: false));
            AddColumn("dbo.LineaVentas", "ColorId", c => c.Int(nullable: false));
            CreateIndex("dbo.LineaVentas", "TalleId");
            CreateIndex("dbo.LineaVentas", "ColorId");
            AddForeignKey("dbo.LineaVentas", "ColorId", "dbo.Colors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.LineaVentas", "TalleId", "dbo.Talles", "Id", cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.LineaVentas", "TalleId", "dbo.Talles");
            DropForeignKey("dbo.LineaVentas", "ColorId", "dbo.Colors");
            DropIndex("dbo.LineaVentas", new[] { "ColorId" });
            DropIndex("dbo.LineaVentas", new[] { "TalleId" });
            DropColumn("dbo.LineaVentas", "ColorId");
            DropColumn("dbo.LineaVentas", "TalleId");
        }
    }
}
