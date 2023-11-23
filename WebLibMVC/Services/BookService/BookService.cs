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

namespace ServiceMVC.BookService
{
    public class BookService : IBookService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IMapper _mapper;

        public BookService(IHttpClientFactory clientFactory, IMapper mapper)
        {
            _clientFactory = clientFactory;
            _mapper = mapper;
        }

        private HttpClient GetClient() => _clientFactory.CreateClient("weblib_api");


        public async Task<bool> AddBookAsync(BookViewModel bookViewModel)
        {
            var client = GetClient();

            if (bookViewModel.Image == null)
                LoadDefaultImage(bookViewModel);
            else
                LoadUserImage(bookViewModel);

            var bookDto = _mapper.Map<BookDto>(bookViewModel);
            var response = await client.PostAsJsonAsync("api/Books/", bookDto);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new HttpRequestException($"Error updating book: {response.StatusCode}");
            }
        }

        public async Task<bool> DeleteBookAsync(int id)
        {
            var client = GetClient();
            var response = await client.DeleteAsync($"api/Books/{id}");

            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<BookViewModel>> GetAllBooksAsync()
        {
            var client = GetClient();
            var response = await client.GetAsync("/api/Books");
            var booksDto = JsonConvert.DeserializeObject<IEnumerable<BookDto>>(await response.Content.ReadAsStringAsync());
            var booksView = _mapper.Map<IEnumerable<BookViewModel>>(booksDto);

            return booksView;
        }

        public async Task<BookViewModel> GetBookAsync(int id)
        {
            var client = GetClient();

            var response = await client.GetAsync($"/api/Books/{id}");

            var bookDto = JsonConvert.DeserializeObject<BookDto>(await response.Content.ReadAsStringAsync());
            var booksView = _mapper.Map<BookViewModel>(bookDto);
            return booksView;
        }

        public async Task<bool> UpdateBookAsync(BookViewModel bookViewModel, int id)
        {
            var client = GetClient();

            if (bookViewModel.Image == null)
                LoadDefaultImage(bookViewModel);
            else
                LoadUserImage(bookViewModel);

            var response = await client.PutAsJsonAsync($"api/Books/{id}", bookViewModel);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new HttpRequestException($"Error while updating book: {response.StatusCode}");
            }
        }

        public async Task<bool> TakeBookAsync(int id)
        {
            var client = GetClient();
            var responseGet = await client.GetAsync($"/api/Books/{id}");
            var bookViewModel = JsonConvert.DeserializeObject<BookViewModel>(await responseGet.Content.ReadAsStringAsync());
            bookViewModel.Quantity--;

            var responsePut = await client.PutAsJsonAsync($"api/Books/{id}", bookViewModel);

            if (responsePut.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new HttpRequestException($"Error while updating book: {responsePut.StatusCode}");
            }
        }

        private static async Task LoadUserImage(BookViewModel bookViewModel)
        {
            using (var memoryStream = new MemoryStream())
            {
                await bookViewModel.Image.CopyToAsync(memoryStream);
                bookViewModel.ImageData = memoryStream.ToArray();
            }
        }

        private static async Task LoadDefaultImage(BookViewModel bookViewModel)
        {
            string defaultImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "default-book-image.jpg");

            using (var fileStream = new FileStream(defaultImagePath, FileMode.Open))
            {
                using (var memoryStream = new MemoryStream())
                {
                    await fileStream.CopyToAsync(memoryStream);
                    bookViewModel.ImageData = memoryStream.ToArray();
                }
            }
        }
    }

}
