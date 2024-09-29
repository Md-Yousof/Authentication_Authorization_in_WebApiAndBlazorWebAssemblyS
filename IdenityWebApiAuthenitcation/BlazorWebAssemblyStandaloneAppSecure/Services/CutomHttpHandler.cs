
using Microsoft.AspNetCore.Components.WebAssembly.Http;

namespace BlazorWebAssemblyStandaloneAppSecure.Services
{
    public class CutomHttpHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.SetBrowserRequestCredentials(BrowserRequestCredentials.Include);
            request.Headers.Add("X-Requested-With", ["XMLHttpRequest"]);
            return base.SendAsync(request, cancellationToken);
        }
    }
}


//using Blazored.LocalStorage;
//namespace BlazorWebAssemblyStandaloneAppSecure.Services    ////For Token Stoge in LocalStorage
//{
//    public class CutomHttpHandler : DelegatingHandler
//    {
//        private readonly ILocalStorageService _localStorageService;

//        public CutomHttpHandler(ILocalStorageService localStorageService)
//        {
//            _localStorageService = localStorageService;
//        }
//        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
//        {
//            var accessToken = await _localStorageService.GetItemAsync<string>("accessToken");
//            request.Headers.Authorization =
//                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
//            return await base.SendAsync(request, cancellationToken);
//        }
//    }
//}
