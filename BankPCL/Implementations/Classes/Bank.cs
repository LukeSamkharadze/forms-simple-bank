using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BankPCL.Abstractions.Interfaces;

namespace BankPCL.Implementations.Classes
{
    public class Bank : IBank
    {
        public static Bank Instance { get; set; } = new Bank();

        public double Balance { get; set; }

        private Bank() { }
    }
}
