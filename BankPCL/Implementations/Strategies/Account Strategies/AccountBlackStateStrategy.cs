using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BankPCL.Abstractions.Interfaces.Strategies;
using BankPCL.Abstractions.Abstract_Classes.Strategies.Account_Strategies;

namespace BankPCL.Implementations.Strategies.Account_Strategies
{
    public class AccountBlackStateStrategy
    {
        public double? Limit { get; set;}
        public double? Rating { get; set; }

        public double WithdrawUsingRaiting(double amount)
        {
            return 0;
        }
    }
}
