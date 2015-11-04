using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective03.Item19
{
    public class Employee : IContactInfo
    {
        public string Name
        {
            get { return "EmployeeName"; }
        }
    }

    public class Customer : IContactInfo
    {
        public string Name
        {
            get { return "CustomerName"; }
        }
    }

    public class Vendor : IContactInfo
    {
        public string Name
        {
            get { return "VendorName"; }
        }
    }

    public interface IContactInfo
    {
        string Name { get; }
    }

    public class _7_Test
    {
        public void PrintName(IContactInfo ic)
        {
            Console.WriteLine(ic.Name);
        }
    }
}
