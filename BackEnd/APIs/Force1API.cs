using BackEnd.DTOs;
using BackEnd.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using System;
using System.Text;


namespace BackEnd.APIs
{
    public class Force1API : IForce1API
    {
        
        public ResponseAPI responseAPI = new ResponseAPI();
        public async Task<ResponseAPI> PegaAtivos()
        {
            
            string endpoint = "https://api.magma-3.com/v2/Auth/Login"; 
            HttpClient httpClient = new HttpClient();
            Uri uri = new Uri(endpoint);
            HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Post, uri);
            httpRequest.Content = new StringContent("{ \r\n'Enterprise': 'magma3teste',\r\n   'Login': 'suporte',\r\n  'Password': 'magma@api@suporte'\r\n}",
                 Encoding.UTF8,
        "application/json");
            HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequest);
            string secondendpoint = "https://api.magma-3.com/v2/Force1/GetAssets?pagination=0&assetType=computador";
            Uri seconduri = new Uri(secondendpoint);
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, seconduri);
            var Response = await httpClient.SendAsync(httpRequestMessage);
            responseAPI = await Response.Content.ReadFromJsonAsync<ResponseAPI>();
            return responseAPI;


        }

        


        

        }
}

