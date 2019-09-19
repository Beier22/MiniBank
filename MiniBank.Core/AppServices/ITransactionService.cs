using MiniBank.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.AppServices
{
    public interface ITransactionService
    {
        Transaction CreateTransaction(Transaction transaction);
        Transaction ReadTransaction(int id);
        List<Transaction> GetAllTransactions();
    }
}
