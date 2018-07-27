using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPCL.Abstractions.Interfaces
{
    public interface IPerson
    {
        string ID { get; set; }

        string FirstName { get; set; }
        string LastName { get; set; }

        double Salary { get; set; }
        
        double Rating { get; set; }

        List<IAccount> Accounts { get; set; }
    }
}
