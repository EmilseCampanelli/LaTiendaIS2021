using LaTiendaIS2021.Dominio.Modelo;
using System;

namespace LaTiendaIS2021.Dominio.Contratos
{
    public class SucursalManager
    {
        private static SucursalManager _sucursal;
        public Sucursal Sucursal { get; set; }

        private static object _lock = new Object();

        public static SucursalManager GetInstance
        {
            get
            {
                if (_sucursal == null) throw new Exception("Sucursal no definida");
                return _sucursal;
            }
        }

        private SucursalManager() { }

        public static void Inicio(Sucursal sucursal)
        {
            lock (_lock)
            {
                if (_sucursal == null)
                {
                    _sucursal = new SucursalManager();

                    _sucursal.Sucursal = sucursal;

                }
                else throw new Exception("Sucursal ya definida");
            }
        }

        public static void Fin()
        {
            lock (_lock)
            {
                if (_sucursal != null) _sucursal = null;
                else throw new Exception("Sucursal no definida");
            }
        }
    }
}
