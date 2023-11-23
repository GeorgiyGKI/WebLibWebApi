using Shared.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ReaderService
{
    public interface IReaderService
    {
        Task<IEnumerable<ReaderDto>> GetAllReadersAsync(bool trackChanges);
        Task<ReaderDto> GetReaderAsync(int id, bool trackChanges);
        Task<ReaderDto> CreateReaderAsync(ReaderDto reader);
        Task DeleteReaderAsync(int id, bool trackChanges);
        Task UpdateReaderAsync(int id, ReaderDto readerForUpdate, bool trackChanges);
    }
}
