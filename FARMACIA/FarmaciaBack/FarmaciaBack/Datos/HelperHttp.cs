using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos
{
    public class HelperHttp
    {
        private static HelperHttp instancia;
        private HttpClient client;
        private HelperHttp()
        {
            client = new HttpClient();
        }
        public static HelperHttp GetInstance()
        {
            if (instancia == null)
                instancia = new HelperHttp();
            return instancia;
        }
        public async Task<ResponseHttp> GetAsync(string url) //los metodos siempre devuelven una cadena (json)
        {
            var result = await client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();

            return new ResponseHttp(result.StatusCode, content);
        }
        public async Task<ResponseHttp> PostAsync(string url, string json) //los metodos siempre devuelven una cadena (json)
        {
            var result = await client.PostAsync(url, new StringContent(json, Encoding.UTF8, "Application/Json")); //quiero hacer un post y el contenido es una cadena formato HttpContent
            var content = await result.Content.ReadAsStringAsync();

            return new ResponseHttp(result.StatusCode, content);
        }
        public async Task<ResponseHttp> PutAsync(string url, string json) 
        {
            var result = await client.PutAsync(url, new StringContent(json, Encoding.UTF8, "Application/Json")); 
            var content = await result.Content.ReadAsStringAsync();

            return new ResponseHttp(result.StatusCode, content);
        }
        public async Task<ResponseHttp> DeleteAsync(string url) 
        {
            var result = await client.DeleteAsync(url); 
            var content = await result.Content.ReadAsStringAsync();

            return new ResponseHttp(result.StatusCode, content);
        }
    }
}
