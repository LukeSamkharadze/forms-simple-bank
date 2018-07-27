using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BankPCL.Abstractions.Interfaces.Strategies.Account_Strategies;

namespace BankPCL.Implementations.Classes.Strategies.Account_Strategies
{
    public class AccountBlackStateStrategy : IAccountStateStrategy
    {
        public double? Limit { get; set;}
        public double? Rating { get; set; }

        public double WithdrawUsingRating(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
