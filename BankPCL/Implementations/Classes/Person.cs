using System;

using System.Collections.Generic;

using BankPCL.Abstractions.Interfaces;
using BankPCL.Abstractions.Interfaces.Strategies.Person_Strategies;

namespace BankPCL.Implementations.Classes
{
    public class Person : IPerson
    {
        public string ID { get; set; } = null;

        public string FirstName { get; set; } = null;
        public string LastName { get; set; } = null;

        public string Password { get; set; } = null;

        public double? Salary { get; set; } = null;
        public double? Rating { get; set; } = null;

        public IMembershipStrategy MembershipStrategy { get; set; }

        public List<IAccount> Accounts { get; set; } = new List<IAccount>();
    }
}
