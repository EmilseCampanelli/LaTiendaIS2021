namespace LaTiendaIs2021.DatosV1.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class version5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CondicionTributarias", "Letra", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.CondicionTributarias", "Letra");
        }
    }
}
