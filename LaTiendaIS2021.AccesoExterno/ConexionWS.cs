using LaTiendaIS2021.Dominio.Contratos;
using LaTiendaIS2021.Dominio.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaTiendaIS2021.AccesoExterno
{
    public class ConexionWS: IConexion
    {
        AdapterLogin adapter = new AdapterLogin();

        public void ConexionAfip(AdapterLogin adapter)
        {
            throw new NotImplementedException();
        }

        public AdapterLogin ConexionLogin()
        {
            LaTiendaIS2021.AccesoExterno.WSLogin.LoginServiceClient service = new LaTiendaIS2021.AccesoExterno.WSLogin.LoginServiceClient();
            var aut = service.SolicitarAutorizacion("E52CE27F-0B1F-4DFE-A610-F2C32EEC6A97");
            adapter.Cuit = aut.Cuit;
            adapter.Sing = aut.Sign;
            adapter.Token = aut.Token;
            return adapter;
        }



    }
}