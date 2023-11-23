using AutoMapper;
using Newtonsoft.Json;
using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WebLibMVC.ViewModels;

namespace ServiceMVC.ReaderService
{
    public class ReaderService : IReaderService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IMapper _mapper;

        public ReaderService(IHttpClientFactory clientFactory, IMapper mapper)
        {
            _clientFactory = clientFactory;
            _mapper = mapper;
        }

        private HttpClient GetClient() => _clientFactory.CreateClient("weblib_api");

        public async Task<bool> AddReaderAsync(ReaderViewModel readerViewModel)
        {
            var client = GetClient();
            var readerDto = _mapper.Map<ReaderDto>(readerViewModel);
            var response = await client.PostAsJsonAsync("api/Readers/", readerDto);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new HttpRequestException($"Error updating reader: {response.StatusCode}");
            }
        }

        public async Task<bool> DeleteReaderAsync(int id)
        {
            var client = GetClient();
            var response = await client.DeleteAsync($"api/Readers/{id}");

            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<ReaderViewModel>> GetAllReadersAsync()
        {
            var client = GetClient();
            var response = await client.GetAsync("/api/Readers");
            var readersDto = JsonConvert.DeserializeObject<IEnumerable<ReaderDto>>(await response.Content.ReadAsStringAsync());
            var readersView = _mapper.Map<IEnumerable<ReaderViewModel>>(readersDto);

            return readersView;
        }

        public async Task<ReaderViewModel> GetReaderAsync(int id)
        {
            var client = GetClient();

            var response = await client.GetAsync($"/api/Readers/{id}");

            var readerViewModel = JsonConvert.DeserializeObject<ReaderViewModel>(await response.Content.ReadAsStringAsync());
            return readerViewModel;
        }

        public async Task<bool> UpdateReaderAsync(ReaderViewModel readerViewModel, int id)
        {
            var client = GetClient();
            var response = await client.PutAsJsonAsync($"api/Readers/{id}", readerViewModel);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new HttpRequestException($"Error while updating reader: {response.StatusCode}");
            }
        }
    }
}
