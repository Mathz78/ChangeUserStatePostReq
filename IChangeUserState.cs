using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace PostRequest
{
    class IChangeUserState
    {
        // public string MakeHttpRequest(List<ChangeUserState> qlqrcoisa)
        // {
            

        //     return "something";
        // }
        private static readonly HttpClient _httpClient = new HttpClient();
        
        public async Task MakePostRequest(List<ChangeUserState> json)
        {
            string jsonString = string.Join( ",", json);
            var stringContent = new StringContent(jsonString);


            using var httpResponse = await _httpClient.PostAsync("https://httpbin.org/post", stringContent);
            httpResponse.EnsureSuccessStatusCode();

            Console.WriteLine(httpResponse.Content);

            Console.WriteLine("hits me");
        }
    }
}