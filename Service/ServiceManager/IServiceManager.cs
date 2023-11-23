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
    public interface IServiceManager
    {
        IAuthorService AuthorService { get; }
        IBookService BookService { get; }
        IGenreService GenreService { get; }
        IReaderService ReaderService { get; }
        ITransactionService TransactionService { get; }
        ITransactionStatusService TransactionStatusService { get; }
        IAuthenticationService AuthenticationService { get; }
    }
}
