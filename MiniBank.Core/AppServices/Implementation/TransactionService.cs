using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MiniBank.Core.DomainServices;
using MiniBank.Core.Entity;

namespace MiniBank.Core.AppServices.Implementation
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepo _transactionRepo;
        public TransactionService(ITransactionRepo transactionRepo)
        {
            _transactionRepo = transactionRepo;
        }
        public Transaction CreateTransaction(Transaction transaction)
        {
            return _transactionRepo.CreateTransaction(transaction);
        }

        public Transaction ReadTransaction(int id)
        {
            return _transactionRepo.ReadTransactionById(id);
        }

        public List<Transaction> GetAllTransactions()
        {
            return _transactionRepo.GetAllTransactions().ToList();
        }
    }
}
