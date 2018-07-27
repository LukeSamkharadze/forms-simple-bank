using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BankPCL.Abstractions.Interfaces;

namespace BankPCL.Implementations.Classes
{
    public class Account : IAccount
    {
        public IPerson Owner { get; set; }

        public string ID { get; set; }
        public double Balance { get; set; }
        public double Loan { get; set; }

        public void RequestLoan(double amount)
        {
            if (amount < Bank.Instance.MaxLoan * Owner.Rating / Bank.Instance.MaxRating)
                Bank.Instance.ReceiveLoanRequest(new LoanRequest() { account = this, amount = amount });

            throw new Exception("Could't Request Loan");
        }

        public void RecieveLoan(double amount)
        {
            Loan += amount;
        }
    }
}
