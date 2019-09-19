using MiniBank.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Infrastructure
{
    public class FakeDB
    {
        List<Customer> Customers = new List<Customer>();
        List<BankAcc> BankAccs = new List<BankAcc>();
        List<Transaction> Transactions = new List<Transaction>();

        private int id = 1;
        private int transId = 1;

        public void SampleCustomers()
        {
            Customer c1 = new Customer
            {
                Id = id++,
                Name = "John Jonathan",
                Address = "Pusher Street 27",
                Phone = "555-Fake-Phone-Number",
                Email = "pussydestroyer69@gmail.com"
            };

            Customer c2 = new Customer
            {
                Id = id++,
                Name = "Nick Nicholason",
                Address = "Hooker City 88",
                Phone = "Hello-555-16283",
                Email = "einstein2.0@gmail.com"
            };

            Customer c3 = new Customer
            {
                Id = id++,
                Name = "Batman",
                Address = "Gotham Street 64",
                Phone = "Turn-On-Batsignal",
                Email = "imnotbrucewayne@brucewayne.enterprises.com"
            };

            Customer c4 = new Customer
            {
                Id = id++,
                Name = "Clark Kent",
                Address = "New York Somewhere",
                Phone = "Superman-Is-Best",
                Email = "supermansemail@gmail.com"
            };

            Customer c5 = new Customer
            {
                Id = id++,
                Name = "Peter Parker",
                Address = "Also New York Somewhere",
                Phone = "Friendly-Neighborhood-Spiderman",
                Email = "letmeintheavengers.ffs@im.desperate.com"
            };
        }

        public void SampleBankAccs()
        {
            BankAcc a1 = new BankAcc
            {
                AccNumber = 123456789,
                Balance = 1000000000.00,
                InterestRate = 6.9,
                Owners = new List<Customer>(),
                Transactions = new List<Transaction>()
            };
        }

        public void SampleTransactions()
        {
            Transaction t1 = new Transaction
            {
                Id = transId++,
                DateTime = DateTime.Now,
                Message = "Im taking all your money MWAHAHAHAHHAHA",
                Amount = 1000000.00
            };
        }
    }
}
