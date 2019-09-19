using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.Entity
{
    public class BankAcc
    {
        public int AccNumber { get; set; }
        public double InterestRate { get; set; }
        public double Balance { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<Customer> Owners { get; set; }
    }
}
