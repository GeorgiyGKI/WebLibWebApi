using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryModels.ReaderRepository
{
    public class ReaderRepository : RepositoryBase<Reader>, IReaderRepository
    {
        public ReaderRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<Reader>> GetAllReadersAsync(bool trackChanges) =>
            await FindAll(trackChanges).ToListAsync();

        public async Task<Reader> GetReaderAsync(int readerId, bool trackChanges) =>
            await FindByCondition(Entity => Entity.Id.Equals(readerId), trackChanges)
                .SingleOrDefaultAsync();

        public void CreateReader(Reader reader) => Create(reader);

        public void DeleteReader(Reader reader) => Delete(reader);
    }
}
