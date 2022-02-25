using LaTiendaIS2021.AccesoExterno.WSAfip;
using LaTiendaIS2021.Dominio.Contratos;
using LaTiendaIS2021.Dominio.Modelo;
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
        ServiceSoapClient client = new ServiceSoapClient();

        public AdapterLogin ConexionLogin()
        {
            LaTiendaIS2021.AccesoExterno.WSLogin.LoginServiceClient service = new LaTiendaIS2021.AccesoExterno.WSLogin.LoginServiceClient();
            var aut = service.SolicitarAutorizacion("E52CE27F-0B1F-4DFE-A610-F2C32EEC6A97");
            adapter.Cuit = aut.Cuit;
            adapter.Sing = aut.Sign;
            adapter.Token = aut.Token;
            return adapter;
        }
        public AdapterAfipResponse ConexionAfip(AdapterLogin adapter, CabComp cab, DetComp det)
        {
            FECAERequest req = new FECAERequest();
            AdapterAfipResponse _aWSFex = new AdapterAfipResponse();

            var con = ConexionAfip();
            var auth = AuthResp(adapter);
           
            var UltmComp = client.FECompUltimoAutorizado(auth, cab.PtoVta, cab.CbteTipo);
            var cbtNro = UltmComp.CbteNro+1;
            
            req.FeCabReq = CabeceraComp(cab);
            req.FeDetReq = DetalleComp(det,cbtNro);

            var response = client.FECAESolicitar(auth, req); 

            foreach(var reps in response.FeDetResp)
            {
                _aWSFex.CAE = reps.CAE;

            }
            _aWSFex.Respuesta = response.FeCabResp.Resultado;

            return _aWSFex;
            
        }

        private FECAEDetRequest[] DetalleComp( DetComp det, int cbt )
        {


            FECAEDetRequest[] detReq = new FECAEDetRequest[]
            {
                new FECAEDetRequest()
                {
                   Concepto = det.Concepto,
                   DocTipo = det.DocTipo,
                   DocNro = det.DocNro,
                   CbteDesde= cbt,
                   CbteHasta= cbt,
                   CbteFch = det.CbtFch,
                   ImpTotal = Math.Round(det.ImpTotal,2),
                   ImpTotConc = Math.Round(det.ImpTotConc, 2),
                  // ImpNeto = Math.Round(det.ImpNeto,2),
                   ImpOpEx = Math.Round(det.ImpOpEx),
                   ImpIVA = det.ImpIva,
                   ImpTrib = det.ImpTrib,
                   MonId= "PES",
                   MonCotiz = det.MonCotiz
                   
                }
            };

            return detReq;
            
        }

        private FECAECabRequest CabeceraComp(CabComp cab)
        {
            FECAECabRequest cabReq = new FECAECabRequest();
            cabReq.CantReg = 1;
            cabReq.CbteTipo = cab.CbteTipo;
            cabReq.PtoVta = cab.PtoVta;

            return cabReq;
        }

        


        private DummyResponse ConexionAfip ()
        {
            return client.FEDummy();
        }

        private FEAuthRequest AuthResp(AdapterLogin adapter)
        {
            FEAuthRequest auth = new FEAuthRequest();
            auth.Cuit = adapter.Cuit;
            auth.Sign = adapter.Sing;
            auth.Token = adapter.Token;

            return auth;
        }

    }
}