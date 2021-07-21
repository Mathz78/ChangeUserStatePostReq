using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using RestEase;

namespace PostRequest
{
    [Header("Authorization", "somethingGoesHere")]
    [Header("Content-Type", "application/json")]
    public interface IChangeUserState
    {
        [Post("https://httpbin.org/post")]
        // Task<ChangeUserState> makePostRequest([Body] List<ChangeUserState> body);
        Task<ChangeUserState> makePostRequest([Body] string body);
    }
}