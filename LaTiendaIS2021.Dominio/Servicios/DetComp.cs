using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTiendaIS2021.Dominio.Servicios
{
    public class DetComp
    {
        public int Concepto { get; set; }
        public int DocTipo { get; set; }
        public long DocNro { get; set; }
        public long CbteDesde { get; set; }
        public long CbteHasta { get; set; }
        public string CbtFch { get; set; }
        public double ImpTotal { get; set; }
        public double PorcentajeIVA { get; set; }
        public double ImpTotConc { get; set;}
        public double ImpNeto => ImpTotal / (1 + (PorcentajeIVA / 100));
        public double ImpOpEx { get; set; }
        public double ImpTrib { get; set; }
        public double ImpIva { get; set; }
        public string MonId { get; set; }
        public double MonCotiz { get; set; } 


    }
}
