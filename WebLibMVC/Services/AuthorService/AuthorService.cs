using AutoMapper;
using Newtonsoft.Json;
using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WebLibMVC.ViewModels;

namespace ServiceMVC.AuthorService
{
    public class AuthorService : IAuthorService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IMapper _mapper;

        public AuthorService(IHttpClientFactory clientFactory, IMapper mapper)
        {
            _clientFactory = clientFactory;
            _mapper = mapper;
        }

        private HttpClient GetClient() => _clientFactory.CreateClient("weblib_api");
        public async Task<bool> AddAuthorAsync(AuthorViewModel authorViewModel)
        {
            var client = GetClient();
            var authorDto = _mapper.Map<AuthorDto>(authorViewModel);
            var response = await client.PostAsJsonAsync("api/Authors/", authorDto);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new HttpRequestException($"Error updating author: {response.StatusCode}");
            }
        }

        public async Task<bool> DeleteAuthorAsync(int id)
        {
            var client = GetClient();
            var response = await client.DeleteAsync($"api/Authors/{id}");

            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<AuthorViewModel>> GetAllAuthorsAsync()
        {
            var client = GetClient();
            var response = await client.GetAsync("/api/Authors");
            var authorsDto = JsonConvert.DeserializeObject<IEnumerable<AuthorDto>>(await response.Content.ReadAsStringAsync());
            var authorsView = _mapper.Map<IEnumerable<AuthorViewModel>>(authorsDto);

            return authorsView;
        }

        public async Task<AuthorViewModel> GetAuthorAsync(int id)
        {
            var client = GetClient();

            var response = await client.GetAsync($"/api/Authors/{id}");

            var authorViewModel = JsonConvert.DeserializeObject<AuthorViewModel>(await response.Content.ReadAsStringAsync());
            return authorViewModel;
        }

        public async Task<bool> UpdateAuthorAsync(AuthorViewModel authorViewModel, int id)
        {
            var client = GetClient();
            var response = await client.PutAsJsonAsync($"api/Authors/{id}", authorViewModel);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new HttpRequestException($"Error while updating author: {response.StatusCode}");
            }
        }
    }
}
