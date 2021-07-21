using System;
using System.Collections.Generic;
using System.Net.Http;

namespace PostRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing a Post Request!");



            List<ChangeUserState> body = new List<ChangeUserState>
            {
                new ChangeUserState {
                    id = Guid.NewGuid(), 
                    to = "postmaster@msging.net", 
                    method = "set", 
                    uri = "/contexts/{{user-identity}}/stateid@{{flow-identifier}}",
                    type = "text/plain",
                    resource = "{{state-id}}"
                }
            };

            // string combindedString = string.Join( ",", requestOne);
 
            // Console.WriteLine(combindedString.GetType());

            IChangeUserState request = new IChangeUserState();

            Console.WriteLine(request.MakePostRequest(body));

            Console.ReadLine();
        }
    }
}
