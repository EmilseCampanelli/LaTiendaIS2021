namespace LaTiendaIs2021.DatosV1.Migrations
{
    using LaTiendaIS2021.Dominio.Modelo;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<LaTiendaIs2021.DatosV1.Data.LaTiendaIs2021DatosV1Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LaTiendaIs2021.DatosV1.Data.LaTiendaIs2021DatosV1Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Productoes.AddOrUpdate(x => x.Id,
                new Producto()
                {
                    Id = 1,
                    Codigo = 111,
                    Descripcion = "Remeras",
                    CostoSinIva = 100,
                    MargenGanancia = (decimal)0.3,
                    PorcentajeIva = (decimal)0.21,
                    //PrecioFinal = (decimal?)500.0, MarcaId = 1, RubroId = 1
                    //
                },
                new Producto()
                {
                    Id = 2,
                    Codigo = 222,
                    Descripcion = "Pantalones",
                    CostoSinIva = 200,
                    MargenGanancia = (decimal)0.3,
                    PorcentajeIva = (decimal)0.21,
                    //  PrecioFinal = (decimal?)600.0,
                    MarcaId = 1,
                    RubroId = 1
                }
                );
            context.Marcas.AddOrUpdate(x => x.Id,
                new Marca()
                {
                    Id = 1,
                    Descripcion = "Adidas"
                },
                new Marca()
                {
                    Id = 2,
                    Descripcion = "Nike"
                },
                new Marca()
                {
                    Id = 3,
                    Descripcion = "Puma"
                }
                );
            context.Rubroes.AddOrUpdate(x => x.Id,
                new Rubro()
                {
                    Id = 1,
                    Descripcion = "Deportivo"
                },
                 new Rubro()
                 {
                     Id = 2,
                     Descripcion = "Elegante"
                 }
                );
        }
    }
}
