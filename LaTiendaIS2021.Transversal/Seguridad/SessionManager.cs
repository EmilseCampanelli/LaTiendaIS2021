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
        public static SessionManager GetInstance
        {
            get
            {
                if (_session == null) throw new Exception("Sesión no iniciada");
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


    }
}
