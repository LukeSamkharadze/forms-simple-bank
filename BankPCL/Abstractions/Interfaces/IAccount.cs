using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPCL.Abstractions.Interfaces
{
    public interface IAccount
    {
        IPerson Owner { get; set; }

        string ID { get; set; }
        
        double? Balance { get; set; }
        double? Loan { get; set; }

        void SendMoney(IAccount receiver, double amount);
        void ReceiveMoney(IAccount sender, double amount);

        void RequestLoan(double amount);
        void RecieveLoan(double amount);

        void PayLoan(double amount)
    }
}
