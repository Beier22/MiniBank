using MiniBank.Core.DomainServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace MiniBank.Infrastructure.Repositories
{
    public class TransactionRepo : ITransactionRepo
    {
        public Transaction CreateTransaction(Transaction toCreate)
        {
            List<Transaction> transactionsList = FakeDB.Transactions.ToList();
            transactionsList.Add(toCreate);
            FakeDB.Transactions = transactionsList;
            return toCreate;

        }

        public Transaction ReadTransactionById(int id)
        {
            foreach (var transaction in FakeDB.Transactions)
            {
                if (transaction.Id == id)
                {
                    return transaction;
                }
            }

            return null;
        }

        public IEnumerable<Transaction> GetAllTransactions()
        {
            return FakeDB.Transactions;
        }
    }
}
