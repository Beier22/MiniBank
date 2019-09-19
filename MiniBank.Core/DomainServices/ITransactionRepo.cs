using MiniBank.Core.Entity;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace MiniBank.Core.DomainServices
{
    public interface ITransactionRepo
    {
        Transaction CreateTransaction(Transaction toCreate);
        Transaction ReadTransactionById(int id);
        IEnumerable<Transaction> GetAllTransactions();
    }
}
