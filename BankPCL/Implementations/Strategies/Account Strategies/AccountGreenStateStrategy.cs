using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BankPCL.Abstractions.Interfaces.Strategies;

namespace BankPCL.Implementations.Strategies.Account_Strategies
{
    public class AccountGreenStateStrategy
    {
        public double Limit { get; set; } = 10000;
        public double Rating { get; set; }

        public double WithdrawUsingRating(double amount)
        {
            if (amount < Limit * Rating / 10)
            {
                return amount;
            }

            throw new Exception("Can't WithdrawUsingRating");
        }
    }
}
