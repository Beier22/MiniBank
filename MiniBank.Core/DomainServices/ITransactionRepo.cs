using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Transactions;

namespace MiniBank.Core.DomainServices
{
    public interface ITransactionRepo
    {
        Transaction CreateTransaction(Transaction toCreate);
        Transaction ReadTransactionById(int id);
        IEnumerable<Transaction> GetAllTransactions();
    }
}
