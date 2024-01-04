using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using LoggerService;
using Shared.DataTransferObject;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BookService
{
    public class BookService : IBookService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public BookService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<(IEnumerable<BookDto> books, MetaData metaData)> GetBooksForPageAsync(BookParameters bookParameters,bool trackChanges)
        {
            var booksWithMetaData = await _repository.Book.GetBooksForPageAsync(bookParameters, trackChanges);
            var booksDto = _mapper.Map<IEnumerable<BookDto>>(booksWithMetaData);

            return (books: booksDto, metaData: booksWithMetaData.MetaData);
        }

        public async Task<BookDto> GetBookAsync(int id, bool trackChanges)
        {
            var book = await _repository.Book.GetBookAsync(id, trackChanges) ?? throw new BookNotFoundException(id);
            var bookDto = _mapper.Map<BookDto>(book);

            return bookDto;
        }

        public async Task<BookDto> CreateBookAsync(BookDto book)
        {
            var bookEntity = _mapper.Map<Book>(book);
            _repository.Book.CreateBook(bookEntity);
            await _repository.SaveAsync();
            var bookToReturn = _mapper.Map<BookDto>(bookEntity);

            return bookToReturn;
        }

        public async Task DeleteBookAsync(int id, bool trackChanges)
        {
            var book = await _repository.Book.GetBookAsync(id, trackChanges) ?? throw new BookNotFoundException(id);
            _repository.Book.DeleteBook(book);
            await _repository.SaveAsync();
        }

        public async Task UpdateBookAsync(int id, BookDto bookForUpdate, bool trackChanges)
        {
            var bookEntity = await _repository.Book.GetBookAsync(id, trackChanges) ?? throw new BookNotFoundException(id);

            _mapper.Map(bookForUpdate, bookEntity);
            bookEntity.Id = id;
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<BookDto>> GetAllBooksAsync(bool trackChanges)
        {
            var books = await _repository.Book.GetAllBooksAsync(trackChanges);
            var booksDto = _mapper.Map<IEnumerable<BookDto>>(books);

            return booksDto;
        }
    }
}
