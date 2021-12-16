using LaTiendaIS2021.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace LaTiendaIs2021.DatosV1.Models
{
    public class Consultas
    {
       
        public static HttpClient client = new HttpClient();


        public static async Task<Uri> CreateAsync(string paht, Object obj)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(paht, obj);
            response.EnsureSuccessStatusCode();

            return response.Headers.Location;

        }

        public static async Task<Object> GetOneAsync(string path, Object obj)
        {
            
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                obj = await response.Content.ReadAsAsync<Object>();
            }
            return obj;
        }

        

    }
}