using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPCL.Abstractions.Interfaces
{
    public interface ILoanRequest
    {
        IAccount account { get; set; }

        double? amount { get; set; }
    }
}
