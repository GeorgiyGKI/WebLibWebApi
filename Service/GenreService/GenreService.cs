using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using LoggerService;
using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.GenreService
{
    public class GenreService : IGenreService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public GenreService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<GenreDto>> GetAllGenresAsync(bool trackChanges)
        {
            var genres = await _repository.Genre.GetAllGenresAsync(trackChanges);
            if (genres is null)
                return null;

            var genresDto = _mapper.Map<IEnumerable<GenreDto>>(genres);

            return genresDto;
        }

        public async Task<GenreDto> GetGenreAsync(int id, bool trackChanges)
        {
            var genre = await _repository.Genre.GetGenreAsync(id, trackChanges) ?? throw new GenreNotFoundException(id);
            var genreDto = _mapper.Map<GenreDto>(genre);

            return genreDto;
        }

        public async Task<GenreDto> CreateGenreAsync(GenreDto genre)
        {
            var genreEntity = _mapper.Map<Genre>(genre);
            _repository.Genre.CreateGenre(genreEntity);
            await _repository.SaveAsync();
            var genreToReturn = _mapper.Map<GenreDto>(genreEntity);

            return genreToReturn;
        }

        public async Task DeleteGenreAsync(int id, bool trackChanges)
        {
            var genre = await _repository.Genre.GetGenreAsync(id, trackChanges) ?? throw new GenreNotFoundException(id);
            _repository.Genre.DeleteGenre(genre);
            await _repository.SaveAsync();
        }

        public async Task UpdateGenreAsync(int id, GenreDto genreForUpdate, bool trackChanges)
        {
            var genreEntity = await _repository.Genre.GetGenreAsync(id, trackChanges) ?? throw new GenreNotFoundException(id);
            var result = _mapper.Map(genreForUpdate, genreEntity) ?? throw new NullReferenceException();
            genreEntity.Id = id;
            await _repository.SaveAsync();
        }
    }
}
