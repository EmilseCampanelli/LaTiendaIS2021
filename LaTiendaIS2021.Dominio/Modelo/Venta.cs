using System.Collections.Generic;
using System.Linq;

namespace LaTiendaIS2021.Dominio.Modelo
{
    public class Venta
    {
        Cliente client;
        //
        public Venta()
        {

            //CalcularTotalVenta();
            this.LineaVenta = new List<LineaVenta>();
            client = new Cliente();   

        }
        public virtual ICollection<LineaVenta> LineaVenta { get; set; }
        public int id { get; set; }
        public System.DateTime? fecha { get; set; }
        public decimal total { get; set; }

       
        public int PuntoVentaId { get; set; }
     
        public int UsuarioId { get; set; }
        public virtual Cliente Cliente { get; set; }
        
        public int ClienteId { get; set; }
        public virtual PuntoVenta PuntoVenta { get; set; }
        public virtual Usuario Usuario { get; set; }
        
        public Conceptos Conceptos { get; set; }
        public int CondicionTributariaId { get; private set; }

        public decimal CalcularTotalVenta()
        {
            total = 0;
            foreach (var i in LineaVenta)
            {
                total = (decimal)(total + i.precio);
            }

            return total;
        }


        public void ConfirmarVenta()
        {
            StockUpdate();
        }



        
        private void StockUpdate()
        {
            foreach (var lv in LineaVenta)
            {
                var prod = lv.Producto;
                lv.StockUpdate(prod, PuntoVenta.SucursalId );
            }
        }

        public Cliente ClientDefault()
        {
                client.Id = 1;
                client.Cuit = "11111111111";
                client.CondicionTributariaId = 1;
                client.CondicionTributaria = new CondicionTributaria()
                {
                    Id = 1,
                    Descripcion = "Consumidor Final",
                    Letra = "B",
                };
                client.Domicilio = "Consumidor Final";
                client.RazonSocial = "Consumidor Final";
           
            return client;
           
        }
      
    }


}
