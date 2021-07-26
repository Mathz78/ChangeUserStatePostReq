using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using PostRequest.Model;
using RestEase;

namespace PostRequest.Interface
{
    [Header("Authorization", "{{yourKey}}")]
    [Header("Content-Type", "application/json")]
    public interface IChangeUserState
    {
        [Post("commands")]
        Task<IChangeUserStateResponse> makePostRequest([Body] ChangeUserState body);
    }
}