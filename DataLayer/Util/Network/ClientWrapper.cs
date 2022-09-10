using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataLayer.Util.Network
{
    public class ClientWrapper : IClientWrapper
    {
    

        public async Task<string> SendRequest(string Uri, HttpMethod method, Dictionary<string, object>? headers = null, string? parameter = null)
        {
            //var json = JsonSerializer.Serialize(data);

            // var content = new StringContent(json, Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage(method, new Uri(Uri));

            if (headers != null)
            {
                foreach (var item in headers)
                {
                    request.Headers.Add(item.Key, item.Value.ToString());
                }
            }


            HttpResponseMessage response;
            using (var client = new HttpClient())
            {
                response = await client.SendAsync(request);

            }

            string resultado = "";
            if (response.IsSuccessStatusCode)
                resultado = await response.Content.ReadAsStringAsync();
            else
                resultado = "Not Found Employee or Service unavaliable";

            return resultado;
        }
    }
}
