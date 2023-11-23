using AutoMapper;
using Newtonsoft.Json.Linq;
using Shared.DataTransferObject;
using WebLibMVC.ViewModels;

namespace ServiceMVC.AuthorizeService
{
    public class AuthorizeService : IAuthorizeService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IMapper _mapper;

        public AuthorizeService(IHttpClientFactory clientFactory, IMapper mapper)
        {
            _clientFactory = clientFactory;
            _mapper = mapper;
        }
        private HttpClient GetClient() => _clientFactory.CreateClient("weblib_api");
        public async Task<string> AuthorizeAsync(AuthorizeViewModel authorizeViewModel)
        {
            var client = GetClient();
            var authorizeDto = _mapper.Map<AuthorizeDto>(authorizeViewModel);
            var response = await client.PostAsJsonAsync("api/authentication/login", authorizeDto);
            if ((int)response.StatusCode == 401)
                throw new HttpRequestException($"Error while login: {response.StatusCode}");
            
            JObject json = JObject.Parse(await response.Content.ReadAsStringAsync());
            string tokenValue = json["token"].Value<string>();

            return tokenValue;

        }
    }
}
