using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BankPCL.Abstractions.Interfaces;

namespace BankPCL.Implementations.Classes
{
    public class LoanRequest : ILoanRequest
    {
        public IAccount account { get; set; } = null;
        public double? amount { get; set; } = null;
    }
}
