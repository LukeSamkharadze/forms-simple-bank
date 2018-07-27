using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BankPCL.Abstractions.Interfaces.Strategies.Account_Strategies;

namespace BankPCL.Abstractions.Abstract_Classes.Strategies.Account_Strategies
{
    public abstract class AccountStateStrategy : IAccountStateStrategy
    {
        public virtual double? Limit { get; set; }
        public virtual double? Rating { get; set; }

        public virtual double WithdrawUsingRating(double amount)
        {
            if (amount < Limit * Rating / 10)
                return amount;

            throw new Exception("Can't WithdrawUsingRating");
        }
    }
}
