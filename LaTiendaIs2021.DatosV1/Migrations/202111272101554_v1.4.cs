namespace LaTiendaIs2021.DatosV1.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class v14 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stocks",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    cantidad = c.Int(),
                    ColorId = c.Int(nullable: false),
                    ProductoId = c.Int(nullable: false),
                    SucursalId = c.Int(nullable: false),
                    TalleId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Colors", t => t.ColorId, cascadeDelete: true)
                .ForeignKey("dbo.Productoes", t => t.ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.Sucursals", t => t.SucursalId, cascadeDelete: true)
                .ForeignKey("dbo.Talles", t => t.TalleId, cascadeDelete: true)
                .Index(t => t.ColorId)
                .Index(t => t.ProductoId)
                .Index(t => t.SucursalId)
                .Index(t => t.TalleId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Stocks", "TalleId", "dbo.Talles");
            DropForeignKey("dbo.Stocks", "SucursalId", "dbo.Sucursals");
            DropForeignKey("dbo.Stocks", "ProductoId", "dbo.Productoes");
            DropForeignKey("dbo.Stocks", "ColorId", "dbo.Colors");
            DropIndex("dbo.Stocks", new[] { "TalleId" });
            DropIndex("dbo.Stocks", new[] { "SucursalId" });
            DropIndex("dbo.Stocks", new[] { "ProductoId" });
            DropIndex("dbo.Stocks", new[] { "ColorId" });
            DropTable("dbo.Stocks");
        }
    }
}
