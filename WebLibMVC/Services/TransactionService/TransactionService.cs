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

namespace ServiceMVC.TransactionService
{
    public class TransactionService : ITransactionService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IMapper _mapper;

        public TransactionService(IHttpClientFactory clientFactory, IMapper mapper)
        {
            _clientFactory = clientFactory;
            _mapper = mapper;
        }

        private HttpClient GetClient() => _clientFactory.CreateClient("weblib_api");

        public async Task<bool> AddTransactionAsync(TransactionViewModel transactionViewModel)
        {
            var client = GetClient();
            var transactionDto = _mapper.Map<TransactionDto>(transactionViewModel);
            var response = await client.PostAsJsonAsync("api/Transactions/", transactionDto);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new HttpRequestException($"Error updating transaction: {response.StatusCode}");
            }
        }

        public async Task<bool> DeleteTransactionAsync(int readerId, int id)
        {
            var client = GetClient();
            var response = await client.DeleteAsync($"api/Transactions/{readerId}/{id}");

            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<TransactionViewModel>> GetAllTransactionsAsync(int readerId)
        {
            var client = GetClient();
            var response = await client.GetAsync($"/api/Transactions/{readerId}");
            var transactionsDto = JsonConvert.DeserializeObject<IEnumerable<TransactionDto>>(await response.Content.ReadAsStringAsync());
            var transactionsView = _mapper.Map<IEnumerable<TransactionViewModel>>(transactionsDto);

            return transactionsView;
        }

        public async Task<TransactionViewModel> GetTransactionAsync(int id, int readerId)
        {
            var client = GetClient();

            var response = await client.GetAsync($"/api/Transactions/{readerId}/{id}");

            var transactionViewModel = JsonConvert.DeserializeObject<TransactionViewModel>(await response.Content.ReadAsStringAsync());
            return transactionViewModel;
        }

        public async Task<bool> UpdateTransactionAsync(TransactionViewModel transactionViewModel, int id, int readerId)
        {
            var client = GetClient();
            var response = await client.PutAsJsonAsync($"api/Transactions/{readerId}/{id}", transactionViewModel);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new HttpRequestException($"Error while updating transaction: {response.StatusCode}");
            }
        }

        public async Task<bool> CloseTransactionAsync(int readerId, int id)
        {
            var client = GetClient();
            var responseGet = await client.GetAsync($"/api/Transactions/{readerId}/{id}");
            var transactionViewModel = JsonConvert.DeserializeObject<TransactionViewModel>(await responseGet.Content.ReadAsStringAsync());
            transactionViewModel.ReturnDate = DateTime.Now;
            transactionViewModel.TransactionStatusId = 2;
            var responsePut = await client.PutAsJsonAsync($"api/Transactions/{readerId}/{id}", transactionViewModel);

            if (responsePut.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new HttpRequestException($"Error while updating transaction: {responsePut.StatusCode}");
            }
        }
    }
}
