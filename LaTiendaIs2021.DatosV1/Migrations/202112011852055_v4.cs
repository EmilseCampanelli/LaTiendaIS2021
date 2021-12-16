namespace LaTiendaIs2021.DatosV1.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class v4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productoes", "PrecioVenta", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }

        public override void Down()
        {
            DropColumn("dbo.Productoes", "PrecioVenta");
        }
    }
}
