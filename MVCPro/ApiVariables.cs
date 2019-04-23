using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace MVCPro
{
    public static class ApiVariables
    {
        public static HttpClient WebApiClient = new HttpClient();
        static ApiVariables()
        {
            WebApiClient.BaseAddress = new Uri("http://localhost:53930/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}