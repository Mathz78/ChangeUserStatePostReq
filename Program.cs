using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestEase;

namespace PostRequest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<ChangeUserState> body = new List<ChangeUserState>
            {
                new ChangeUserState {
                    id = Guid.NewGuid(), 
                    to = "postmaster@msging.net", 
                    method = "set", 
                    uri = "/contexts/testing/stateid@someiD",
                    type = "text/plain",
                    resource = "{{state-id}}"
                }
            };

            IChangeUserState api = RestClient.For<IChangeUserState>("https://httpbin.org/");
            var something = api.makePostRequest("https://httpbin.org/");
            ChangeUserState result = api.makePostRequest("https://httpbin.org/").Result;
        
            // Console.WriteLine(something);

            // Console.WriteLine(api.Result);

            Console.WriteLine("koe");
            Console.ReadLine();
        }
    }
}
