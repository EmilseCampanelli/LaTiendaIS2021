using LaTiendaIS2021.Dominio.Modelo;
using System;

namespace LaTiendaIS2021.Dominio.Contratos
{
    public class PuntoVentaManager
    {
        private static PuntoVentaManager _pVenta;

        public PuntoVenta Pveta { get; set; }

        private static object _lock = new Object();

        public static PuntoVentaManager GetInstance
        {
            get
            {
                if (_pVenta == null) throw new Exception("Punto de Venta no definido");
                return _pVenta;
            }
        }

        private PuntoVentaManager() { }

        public static void Inicio(PuntoVenta pventa)
        {
            lock (_lock)
            {
                if (_pVenta == null)
                {
                    _pVenta = new PuntoVentaManager();

                    _pVenta.Pveta = pventa;

                }
                else throw new Exception("Punto de Venta ya definido");
            }
        }

        public static void Fin()
        {
            lock (_lock)
            {
                if (_pVenta != null) _pVenta = null;
                else throw new Exception("Punto de Venta no definido");
            }
        }
    }
}
