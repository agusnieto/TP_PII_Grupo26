using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos
{
    public class ResponseHttp
    {
        public HttpStatusCode StatusCode { get; set; }
        public string? Data { get; set; } // ? para indicar que puede llegar Nulo
        public ResponseHttp(HttpStatusCode statusCode, string? data)
        {
            StatusCode = statusCode;
            Data = data;
        }
    }
}
