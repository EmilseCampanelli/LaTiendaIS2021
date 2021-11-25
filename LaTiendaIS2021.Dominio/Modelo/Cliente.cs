
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTiendaIS2021.Dominio.Modelo
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Cuit { get; set; }
        public string RazonSocial { get; set; }
        public string Domicilio { get; set; }

        public int CondicionTributariaId { get; set; }
        public virtual CondicionTributaria CondicionTributaria { get; set; }
      
    }
}
