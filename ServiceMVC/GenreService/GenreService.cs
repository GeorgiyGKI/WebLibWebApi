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

namespace ServiceMVC.GenreService
{
    public class GenreService : IGenreService
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly IMapper _mapper;

        public GenreService(IHttpClientFactory clientFactory, IMapper mapper)
        {
            _clientFactory = clientFactory;
            _mapper = mapper;
        }

        private HttpClient GetClient()
        {
            return _clientFactory.CreateClient("maddoctors_api");
        }

        public async Task<bool> AddGenreAsync(GenreViewModel genreViewModel)
        {
            var client = GetClient();
            var genreDto = _mapper.Map<GenreDto>(genreViewModel);
            var response = await client.PostAsJsonAsync("api/Genres/", genreDto);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new HttpRequestException($"Error updating genre: {response.StatusCode}");
            }
        }

        public async Task<bool> DeleteGenreAsync(int id)
        {
            var client = GetClient();
            var response = await client.DeleteAsync($"api/Genres/{id}");

            return response.IsSuccessStatusCode;
        }

        public async Task<IEnumerable<GenreViewModel>> GetAllGenresAsync()
        {
            var client = GetClient();
            var response = await client.GetAsync("/api/Genres");
            var genresDto = JsonConvert.DeserializeObject<IEnumerable<GenreDto>>(await response.Content.ReadAsStringAsync());
            var genresView = _mapper.Map<IEnumerable<GenreViewModel>>(genresDto);

            return genresView;
        }

        public async Task<GenreViewModel> GetGenreAsync(int id)
        {
            var client = GetClient();

            var response = await client.GetAsync($"/api/Genres/{id}");

            var genreViewModel = JsonConvert.DeserializeObject<GenreViewModel>(await response.Content.ReadAsStringAsync());
            return genreViewModel;
        }

        public async Task<bool> UpdateGenreAsync(GenreViewModel genreViewModel, int id)
        {
            var client = GetClient();
            var response = await client.PutAsJsonAsync($"api/Genres/{id}", genreViewModel);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new HttpRequestException($"Error while updating genre: {response.StatusCode}");
            }
        }
    }
}
