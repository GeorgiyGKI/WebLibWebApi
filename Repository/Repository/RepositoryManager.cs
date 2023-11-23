using Contracts;
using Repository.RepositoryModels.AuthorRepository;
using Repository.RepositoryModels.BookRepository;
using Repository.RepositoryModels.GenreRepository;
using Repository.RepositoryModels.ReaderRepository;
using Repository.RepositoryModels.TransactionRepository;
using Repository.RepositoryModels.TransactonStatusRepository;

namespace Repository 
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IAuthorRepository> _authorRepository;
        private readonly Lazy<IBookRepository> _bookRepository;
        private readonly Lazy<IGenreRepository> _genreRepository;
        private readonly Lazy<IReaderRepository> _readerRepository;
        private readonly Lazy<ITransactionRepository> _transactionRepository;
        private readonly Lazy<ITransactionStatusRepository> _transactionStatusRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _authorRepository = new Lazy<IAuthorRepository>(() => new AuthorRepository(repositoryContext));
            _bookRepository = new Lazy<IBookRepository>(() => new BookRepository(repositoryContext));
            _genreRepository = new Lazy<IGenreRepository>(() => new GenreRepository(repositoryContext));
            _readerRepository = new Lazy<IReaderRepository>(() => new ReaderRepository(repositoryContext));
            _transactionRepository = new Lazy<ITransactionRepository>(() => new TransactionRepository(repositoryContext));
            _transactionStatusRepository = new Lazy<ITransactionStatusRepository>(() => new TransactionStatusRepository(repositoryContext));
        }

        public IAuthorRepository Author => _authorRepository.Value;
        public IBookRepository Book => _bookRepository.Value;
        public IGenreRepository Genre => _genreRepository.Value;
        public IReaderRepository Reader => _readerRepository.Value;
        public ITransactionRepository Transaction => _transactionRepository.Value;
        public ITransactionStatusRepository TransactionStatus => _transactionStatusRepository.Value;
        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}