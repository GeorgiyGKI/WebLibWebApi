using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository.RepositoryModels.TransactonStatusRepository
{
    public class TransactionStatusRepository : RepositoryBase<TransactionStatus>, ITransactionStatusRepository
    {
        public TransactionStatusRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<TransactionStatus>> GetAllTransactionStatusesAsync(bool trackChanges) =>
            await FindAll(trackChanges).ToListAsync();

        public async Task<TransactionStatus> GetTransactionStatusAsync(int transactionStatusId, bool trackChanges) =>
            await FindByCondition(Entity => Entity.Id.Equals(transactionStatusId), trackChanges)
                .SingleOrDefaultAsync();

        public void CreateTransactionStatus(TransactionStatus transactionStatus) => Create(transactionStatus);

        public void DeleteTransactionStatus(TransactionStatus transactionStatus) => Delete(transactionStatus);
    }

   
}
