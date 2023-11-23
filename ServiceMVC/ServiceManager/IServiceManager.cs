using ServiceMVC.AuthorService;
using ServiceMVC.BookService;
using ServiceMVC.GenreService;
using ServiceMVC.ReaderService;
using ServiceMVC.TransactionService;
using ServiceMVC.TransactionStatusService;

namespace ServiceMVC.ServiceManager
{
    public interface IServiceManager
    {
        IAuthorService AuthorService { get; }
        IBookService BookService { get; }
        IGenreService GenreService { get; }
        IReaderService ReaderService { get; }
        ITransactionService TransactionService { get; }
        ITransactionStatusService TransactionStatusService { get; }
    }
}