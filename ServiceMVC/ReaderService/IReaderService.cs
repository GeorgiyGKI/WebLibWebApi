using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibMVC.ViewModels;

namespace ServiceMVC.ReaderService
{
    public interface IReaderService
    {
        Task<bool> AddReaderAsync(ReaderViewModel readerViewModel);
        Task<bool> DeleteReaderAsync(int id);
        Task<IEnumerable<ReaderViewModel>> GetAllReadersAsync();
        Task<ReaderViewModel> GetReaderAsync(int id);
        Task<bool> UpdateReaderAsync(ReaderViewModel readerViewModel, int id);
    }
}
