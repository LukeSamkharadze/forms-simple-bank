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
        public string ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Salary { get; set; }
        public double Rating { get; set; }

        public List<ILoanRequest> Accounts { get; set; }
    }
}
