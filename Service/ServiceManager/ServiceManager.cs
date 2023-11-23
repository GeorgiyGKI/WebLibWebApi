using AutoMapper;
using Contracts;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Service.AuthenticationService;
using Service.AuthorService;
using Service.BookService;
using Service.GenreService;
using Service.ReaderService;
using Service.TransactionService;
using Service.TransactionStatusService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ServiceManager
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAuthorService> _authorService;
        private readonly Lazy<IBookService> _bookService;
        private readonly Lazy<IGenreService> _genreService;
        private readonly Lazy<IReaderService> _readerService;
        private readonly Lazy<ITransactionService> _transactionService;
        private readonly Lazy<ITransactionStatusService> _transactionStatusService;
        private readonly Lazy<IAuthenticationService> _authenticationService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger,
                              IMapper mapper, UserManager<Admin> UserManager,
                              RoleManager<IdentityRole> RoleManager, IConfiguration configuration)
        {
            _authorService = new Lazy<IAuthorService>(() => new AuthorService.AuthorService(repositoryManager, logger, mapper));
            _bookService = new Lazy<IBookService>(() => new BookService.BookService(repositoryManager, logger, mapper));
            _genreService = new Lazy<IGenreService>(() => new GenreService.GenreService(repositoryManager, logger, mapper));
            _readerService = new Lazy<IReaderService>(() => new ReaderService.ReaderService(repositoryManager, logger, mapper));
            _transactionService = new Lazy<ITransactionService>(() => new TransactionService.TransactionService(repositoryManager, logger, mapper));
            _transactionStatusService = new Lazy<ITransactionStatusService>(() => new TransactionStatusService.TransactionStatusService(repositoryManager, logger, mapper));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService.AuthenticationService(logger, mapper, UserManager, RoleManager, configuration));
        }
        public IAuthorService AuthorService => _authorService.Value;
        public IBookService BookService => _bookService.Value;
        public IGenreService GenreService => _genreService.Value;
        public IReaderService ReaderService =>  _readerService.Value;
        public ITransactionService TransactionService => _transactionService.Value;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;
        public ITransactionStatusService TransactionStatusService =>  _transactionStatusService.Value;
    }
}
