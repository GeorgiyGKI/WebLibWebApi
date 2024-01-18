using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository;
using System.IO.Pipelines;
using System.Linq.Dynamic.Core;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace WebLibWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SqlQueriesController : ControllerBase
    {
        private readonly RepositoryContext _repositoryContext;
        public SqlQueriesController(RepositoryContext repositoryContext) => _repositoryContext = repositoryContext;

        //https://localhost:5001/api/sqlqueries/AuthorFirstNamesStartingWithA/
        [HttpGet("AuthorFirstNamesStartingWithA")]  
        public IActionResult AuthorFirstNamesStartingWithA()
        {
            var authors = _repositoryContext.Authors.Select(a => a)
                                                    .Where(a => EF.Functions.Like(a.FirstName, "a%"))
                                                    .ToList();

            return Ok(authors);
        }
        //https://localhost:5001/api/sqlqueries/ReadersWhoHaveMoreBooksThan/2
        [HttpGet("ReadersWhoHaveMoreBooksThan/{countBooks:int}")]
        public IActionResult ReadersWhoHaveMoreBooksThan(int countBooks)
        {
            FormattableString query = FormattableStringFactory.Create("SELECT R.Id, R.FirstName, R.LastName, R.Address, R.PhoneNumber, R.RegistrationDate " +
                                          "FROM Readers  as R " +
                                          "JOIN Transactions As T " +
                                          "    ON T.ReaderId = R.Id " +
                                          "JOIN Books As B " +
                                          "    ON B.Id = T.BookId " +
                                          "GROUP BY R.Id, R.FirstName,  R.LastName, R.Address, R.PhoneNumber, R.RegistrationDate " +
                                          $"HAVING COUNT(B.Title) > {countBooks}");

     

            var readers = _repositoryContext.Readers.FromSqlInterpolated(query);
   
            return Ok(readers.ToList());
        }

        //https://localhost:5001/api/sqlqueries/Top3YearOfPublishing
        [HttpGet("Top3YearOfPublishing")]
        public IActionResult Top3YearOfPublishing()
        {
            var selected = (from book in _repositoryContext.Books
                            group book by book.Year into grp
                            orderby grp.Count() descending
                            select new
                            {
                                Year = grp.Key,
                                Title = grp.Select(a => a.Title).ToList()
                            }).Take(3);

            return new JsonResult(selected.ToArray());
        }

        //https://localhost:5001/api/sqlqueries/EveryTakenBookFromEveryReader
        [HttpGet("EveryTakenBookFromEveryReader")]
        public IActionResult EveryTakenBookFromEveryReader()
        {
            var selected = from reader in _repositoryContext.Readers
                           join transaction in _repositoryContext.Transactions on reader.Id equals transaction.ReaderId
                           join book in _repositoryContext.Books on transaction.BookId equals book.Id
                           orderby reader.FirstName
                           select new
                           {
                               ReaderName = $"{reader.FirstName} {reader.LastName}",
                               BookTitle = book.Title,
                               book.Year
                           };

            return new JsonResult(selected.ToArray());
        }
    }
}
