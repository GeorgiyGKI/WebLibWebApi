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

namespace Service.TransactionStatusService
{

    public class TransactionStatusService : ITransactionStatusService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public TransactionStatusService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TransactionStatusDto>> GetAllTransactionStatusesAsync(bool trackChanges)
        {
            var transactionStatuses = await _repository.TransactionStatus.GetAllTransactionStatusesAsync(trackChanges);
            var transactionStatusesDto = _mapper.Map<IEnumerable<TransactionStatusDto>>(transactionStatuses);

            return transactionStatusesDto;
        }

        public async Task<TransactionStatusDto> GetTransactionStatusAsync(int id, bool trackChanges)
        {
            var transactionStatus = await _repository.TransactionStatus.GetTransactionStatusAsync(id, trackChanges)
                                          ?? throw new TransactionStatusNotFoundException(id);
            var transactionStatusDto = _mapper.Map<TransactionStatusDto>(transactionStatus);

            return transactionStatusDto;
        }

        public async Task<TransactionStatusDto> CreateTransactionStatusAsync(TransactionStatusDto transactionStatus)
        {
            var transactionStatusEntity = _mapper.Map<TransactionStatus>(transactionStatus);
            _repository.TransactionStatus.CreateTransactionStatus(transactionStatusEntity);
            await _repository.SaveAsync();
            var transactionStatusToReturn = _mapper.Map<TransactionStatusDto>(transactionStatusEntity);

            return transactionStatusToReturn;
        }

        public async Task DeleteTransactionStatusAsync(int id, bool trackChanges)
        {
            var transactionStatus = await _repository.TransactionStatus.GetTransactionStatusAsync(id, trackChanges) 
                                          ?? throw new TransactionStatusNotFoundException(id);
            _repository.TransactionStatus.DeleteTransactionStatus(transactionStatus);
            await _repository.SaveAsync();
        }

        public async Task UpdateTransactionStatusAsync(int id, TransactionStatusDto transactionStatusForUpdate, bool trackChanges)
        {
            var transactionStatusEntity = await _repository.TransactionStatus.GetTransactionStatusAsync(id, trackChanges) 
                                                ?? throw new TransactionStatusNotFoundException(id);
            _mapper.Map(transactionStatusForUpdate, transactionStatusEntity);
            transactionStatusEntity.Id = id;
            await _repository.SaveAsync();
        }
    }
}

