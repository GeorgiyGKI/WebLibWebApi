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

namespace ServiceMVC.TransactionStatusService
{
    public class TransactionStatusService : ITransactionStatusService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IMapper _mapper;

        public TransactionStatusService(IHttpClientFactory clientFactory, IMapper mapper)
        {
            _clientFactory = clientFactory;
            _mapper = mapper;
        }

        private HttpClient GetClient() => _clientFactory.CreateClient("weblib_api");

        public async Task<bool> AddTransactionStatusAsync(TransactionStatusViewModel transactionStatusViewModel)
        {
            var client = GetClient();
            var transactionStatusDto = _mapper.Map<TransactionStatusDto>(transactionStatusViewModel);
            var response = await client.PostAsJsonAsync("api/TransactionStatuses/", transactionStatusDto);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new HttpRequestException($"Error updating transaction status: {response.StatusCode}");
            }
        }

        public async Task<bool> DeleteTransactionStatusAsync(int id)
        {
            var client = GetClient();
            var response = await client.DeleteAsync($"api/TransactionStatuses/{id}");

            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<TransactionStatusViewModel>> GetAllTransactionStatusesAsync()
        {
            var client = GetClient();
            var response = await client.GetAsync("/api/TransactionStatuses");
            var transactionStatusesDto = JsonConvert.DeserializeObject<IEnumerable<TransactionStatusDto>>(await response.Content.ReadAsStringAsync());
            var transactionStatusesView = _mapper.Map<IEnumerable<TransactionStatusViewModel>>(transactionStatusesDto);

            return transactionStatusesView;
        }

        public async Task<TransactionStatusViewModel> GetTransactionStatusAsync(int id)
        {
            var client = GetClient();

            var response = await client.GetAsync($"/api/TransactionStatuses/{id}");

            var transactionStatusViewModel = JsonConvert.DeserializeObject<TransactionStatusViewModel>(await response.Content.ReadAsStringAsync());
            return transactionStatusViewModel;
        }

        public async Task<bool> UpdateTransactionStatusAsync(TransactionStatusViewModel transactionStatusViewModel, int id)
        {
            var client = GetClient();
            var response = await client.PutAsJsonAsync($"api/TransactionStatuses/{id}", transactionStatusViewModel);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new HttpRequestException($"Error while updating transaction status: {response.StatusCode}");
            }
        }

    }

}
