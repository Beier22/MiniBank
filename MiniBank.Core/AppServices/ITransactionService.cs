using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace MiniBank.Core.AppServices
{
    public interface ITransactionService
    {
        Transaction CreateTransaction(Transaction transaction);
        Transaction ReadTransaction(int id);
        List<Transaction> GetAllTransactions();
    }
}
