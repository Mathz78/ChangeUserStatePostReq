using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using PostRequest.Interface;
using Newtonsoft.Json;
using RestEase;
using PostRequest.Model;

namespace PostRequest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ChangeUserState bodyRequest = new ChangeUserState(){
                id = Guid.NewGuid(),
                to = "postmaster@msging.net",
                method = "set",
                uri = "/contexts/{{userId}}/stateid@{{flowId}}",
                type = "text/plain",
                resource = "8ab20ae9-32e2-4502-a7f8-15c4d2d01871"
            };

            IChangeUserState api = RestClient.For<IChangeUserState>("https://http.msging.net/");
            IChangeUserStateResponse response = api.makePostRequest(bodyRequest).Result;

            Console.WriteLine("A requisição foi enviada.");
            Console.WriteLine($"O status da requisição foi: {response.status}");
            Console.ReadLine();
        }
    }
}
