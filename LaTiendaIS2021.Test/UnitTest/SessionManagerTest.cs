using LaTiendaIS2021.Dominio.Modelo;
using LaTiendaIS2021.Transversal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTiendaIS2021.Test.UnitTest
{
    [TestClass]
    public class SessionManagerTest
    {
        [TestMethod]
        public void LoginDeUsuarioConSesionNoIniciada()
        {
            SessionManager.Logout();
            var user = Factory.UsuarioFactory();

            SessionManager.Login(user);

            Assert.IsTrue(SessionManager.GetInstanceSession != null);
        }


        [TestMethod]
        public void LoginDeUsuarioConSesionIniciada()
        {
            SessionManager.Login(Factory.UsuarioFactory());

            var userNew = new Usuario()
            {
                usuario = "emi",
                contraseña = "123",
            };

           

            Assert.ThrowsException<Exception>(()=>SessionManager.Login(userNew),"Sesion ya iniciada");
        }
    }
}
