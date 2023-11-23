using AutoMapper;
using ServiceMVC.AuthorService;
using ServiceMVC.BookService;
using ServiceMVC.GenreService;
using ServiceMVC.ReaderService;
using ServiceMVC.TransactionService;
using ServiceMVC.TransactionStatusService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceMVC.ServiceManager
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAuthorService> _authorService;
        private readonly Lazy<IBookService> _bookService;
        private readonly Lazy<IGenreService> _genreService;
        private readonly Lazy<IReaderService> _readerService;
        private readonly Lazy<ITransactionService> _transactionService;
        private readonly Lazy<ITransactionStatusService> _transactionStatusService;

        public ServiceManager(IHttpClientFactory clientFactory, IMapper mapper)
        {
            _authorService = new Lazy<IAuthorService>(() => new AuthorService.AuthorService(clientFactory, mapper));
            _bookService = new Lazy<IBookService>(() => new BookService.BookService(clientFactory, mapper));
            _genreService = new Lazy<IGenreService>(() => new GenreService.GenreService(clientFactory, mapper));
            _readerService = new Lazy<IReaderService>(() => new ReaderService.ReaderService(clientFactory, mapper));
            _transactionService = new Lazy<ITransactionService>(() => new TransactionService.TransactionService(clientFactory, mapper));
            _transactionStatusService = new Lazy<ITransactionStatusService>(() => new TransactionStatusService.TransactionStatusService(clientFactory, mapper));

        }
        public IAuthorService AuthorService => _authorService.Value;
        public IBookService BookService => _bookService.Value;
        public IGenreService GenreService => _genreService.Value;
        public IReaderService ReaderService => _readerService.Value;
        public ITransactionService TransactionService => _transactionService.Value;
        public ITransactionStatusService TransactionStatusService => _transactionStatusService.Value;
    }
}
