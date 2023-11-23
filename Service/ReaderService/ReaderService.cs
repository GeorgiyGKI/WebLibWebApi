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

namespace Service.ReaderService
{
    public class ReaderService : IReaderService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ReaderService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ReaderDto>> GetAllReadersAsync(bool trackChanges)
        {
            var readers = await _repository.Reader.GetAllReadersAsync(trackChanges);
            var readersDto = _mapper.Map<IEnumerable<ReaderDto>>(readers);

            return readersDto;
        }

        public async Task<ReaderDto> GetReaderAsync(int id, bool trackChanges)
        {
            var reader = await _repository.Reader.GetReaderAsync(id, trackChanges) ?? throw new ReaderNotFoundException(id);
            var readerDto = _mapper.Map<ReaderDto>(reader);

            return readerDto;
        }

        public async Task<ReaderDto> CreateReaderAsync(ReaderDto reader)
        {
            var readerEntity = _mapper.Map<Reader>(reader);
            _repository.Reader.CreateReader(readerEntity);
            await _repository.SaveAsync();
            var readerToReturn = _mapper.Map<ReaderDto>(readerEntity);

            return readerToReturn;
        }

        public async Task DeleteReaderAsync(int id, bool trackChanges)
        {
            var reader = await _repository.Reader.GetReaderAsync(id, trackChanges) ?? throw new ReaderNotFoundException(id);
            _repository.Reader.DeleteReader(reader);
            await _repository.SaveAsync();
        }

        public async Task UpdateReaderAsync(int id, ReaderDto readerForUpdate, bool trackChanges)
        {
            var readerEntity = await _repository.Reader.GetReaderAsync(id, trackChanges) ?? throw new ReaderNotFoundException(id);
            _mapper.Map(readerForUpdate, readerEntity);
            readerEntity.Id = id;
            await _repository.SaveAsync();
        }
    }

}
