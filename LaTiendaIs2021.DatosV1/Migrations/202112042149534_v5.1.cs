namespace LaTiendaIs2021.DatosV1.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class v51 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LineaVentas", "precio", c => c.Decimal(precision: 18, scale: 2));
        }

        public override void Down()
        {
            DropColumn("dbo.LineaVentas", "precio");
        }
    }
}
