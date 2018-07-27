using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BankPCL.Abstractions.Interfaces;

namespace BankPCL.Implementations.Classes
{
    public class Person : IPerson
    {
        public string ID { get; set; } = null;

        public string FirstName { get; set; } = null;
        public string LastName { get; set; } = null;

        public double? Salary { get; set; } = null;
        public double? Rating { get; set; } = null;

        public List<ILoanRequest> Accounts { get; set; } = new List<ILoanRequest>();
    }
}
