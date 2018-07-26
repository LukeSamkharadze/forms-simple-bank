using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPCL.Abstractions.Interfaces.Strategies.Account_Strategies
{
    public interface IAccountStateStrategy
    {
        double? Limit { get; set; }
        double? Rating { get; set; }

        double WithdrawUsingRating(double amount);
    }
}
