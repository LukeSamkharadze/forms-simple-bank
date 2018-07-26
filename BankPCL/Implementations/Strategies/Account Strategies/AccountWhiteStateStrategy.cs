using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BankPCL.Abstractions.Interfaces.Strategies;

namespace BankPCL.Implementations.Strategies.Account_Strategies
{
    public class AccountWhiteStateStrategy
    {
        public double? Limit { get; set; }
        public double? Rating { get; set; }

    }
}
