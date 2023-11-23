using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryModels.ReaderRepository
{
    public interface IReaderRepository
    {
        Task<IEnumerable<Reader>> GetAllReadersAsync(bool trackChanges);
        Task<Reader> GetReaderAsync(int readerId, bool trackChanges);
        void CreateReader(Reader reader);
        void DeleteReader(Reader reader);
    }
}
