using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using LoggerService;
using Shared.DataTransferObject;


namespace Service.TransactionService
{
   
    public class TransactionService : ITransactionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public TransactionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TransactionDto>> GetAllTransactionsAsync(int readerId, bool trackChanges)
        {
            var transactions = await _repository.Transaction.GetAllTransactionsAsync(readerId, trackChanges);
            var transactionsDto = _mapper.Map<IEnumerable<TransactionDto>>(transactions);

            return transactionsDto;
        }

        public async Task<TransactionDto> GetTransactionAsync(int readerId, int id, bool trackChanges)
        {
            var transaction = await _repository.Transaction.GetTransactionAsync(readerId, id, trackChanges)
                              ?? throw new TransactionNotFoundException(id);

            var transactionDto = _mapper.Map<TransactionDto>(transaction);

            return transactionDto;
        }

        public async Task<TransactionDto> CreateTransactionAsync(TransactionDto transaction)
        {
            var transactionEntity = _mapper.Map<Transaction>(transaction);
            _repository.Transaction.CreateTransaction(transactionEntity);
            await _repository.SaveAsync();
            var transactionToReturn = _mapper.Map<TransactionDto>(transactionEntity);

            return transactionToReturn;
        }

        public async Task DeleteTransactionAsync(int readerId, int id, bool trackChanges)
        {
            var transaction = await _repository.Transaction.GetTransactionAsync(readerId, id, trackChanges)
                              ?? throw new TransactionNotFoundException(id);
            _repository.Transaction.DeleteTransaction(transaction);
            await _repository.SaveAsync();
        }

        public async Task UpdateTransactionAsync(int readerId, int id, TransactionDto transactionForUpdate, bool trackChanges)
        {
            var transactionEntity = await _repository.Transaction.GetTransactionAsync(readerId, id, trackChanges)
                                    ?? throw new TransactionNotFoundException(id);
            _mapper.Map(transactionForUpdate, transactionEntity);
            transactionEntity.Id = id;
            await _repository.SaveAsync();
        }
    }
}

