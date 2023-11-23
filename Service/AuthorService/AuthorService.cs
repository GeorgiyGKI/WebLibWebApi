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

namespace Service.AuthorService
{
    public class AuthorService : IAuthorService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AuthorService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AuthorDto>> GetAllAuthorsAsync(bool trackChanges)
        {
            var authors = await _repository.Author.GetAllAuthorsAsync(trackChanges);
            var authorsDto = _mapper.Map<IEnumerable<AuthorDto>>(authors);

            return authorsDto;
        }

        public async Task<AuthorDto> GetAuthorAsync(int id, bool trackChanges)
        {
            var author = await _repository.Author.GetAuthorAsync(id, trackChanges) ?? throw new AuthorNotFoundException(id);
            var authorDto = _mapper.Map<AuthorDto>(author);

            return authorDto;
        }

        public async Task<AuthorDto> CreateAuthorAsync(AuthorDto author)
        {
            var authorEntity = _mapper.Map<Author>(author);
            _repository.Author.CreateAuthor(authorEntity);
            await _repository.SaveAsync();
            var authorToReturn = _mapper.Map<AuthorDto>(authorEntity);

            return authorToReturn;
        }

        public async Task DeleteAuthorAsync(int id, bool trackChanges)
        {
            var author = await _repository.Author.GetAuthorAsync(id, trackChanges) ?? throw new AuthorNotFoundException(id);
            _repository.Author.DeleteAuthor(author);
            await _repository.SaveAsync();
        }

        public async Task UpdateAuthorAsync(int id, AuthorDto authorForUpdate, bool trackChanges)
        {
            var authorEntity = await _repository.Author.GetAuthorAsync(id, trackChanges) ?? throw new AuthorNotFoundException(id);
            _mapper.Map(authorForUpdate, authorEntity);
            authorEntity.Id = id;
            await _repository.SaveAsync();
        }   
    }
}
