using System;
using System.Collections.Generic;
using System.Text;

namespace MiniBank.Core.Entity
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string Message { get; set; }
        public double Amount { get; set; }

    }
}
