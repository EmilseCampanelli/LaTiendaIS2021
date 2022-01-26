using LaTiendaIS2021.Dominio.Modelo;
using System;

namespace LaTiendaIS2021.Transversal
{
    public class SessionManager
    {
        private static SessionManager _session;
        public Usuario usuario { get; set; }
        public DateTime FechaInicioSesion { get; set; }

        private static object _lock = new Object();

        public PuntoVenta PuntoVenta { get; set; }
        public Sucursal Sucursal { get; set; }
        public static SessionManager GetInstanceSession
        {
            get
            {
                if (_session.usuario == null) throw new Exception("Sesión no iniciada");
                return _session;
            }
        }

        

     

        private SessionManager()
        {

        }

        public static void Login(Usuario usuario)
        {
            lock (_lock)
            {
                if (_session == null)
                {
                    _session = new SessionManager();

                    _session.usuario = usuario;
                    _session.FechaInicioSesion = DateTime.Now;
                }
                else throw new Exception("Sesión ya iniciada");
            }
        }

        public static void Logout()
        {
            lock (_lock)
            {
                if (_session != null) _session = null;
                else throw new Exception("Sesión no iniciada");
            }
        }


        public static void Inicio(Sucursal sucursal, PuntoVenta pventa)
        {
            lock (_lock)
            {
                if (_session.usuario != null && _session.PuntoVenta == null && _session.Sucursal == null)
                {

                    _session.Sucursal = sucursal;
                    _session.PuntoVenta = pventa;

                }
                else throw new Exception("Sucursal ya definida");
            }
        }

        

    }
}
