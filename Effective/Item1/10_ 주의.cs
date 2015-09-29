using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item1
{
    class _10__주의
    {
        public void Func()
        {
            var customer = new Customer();
            string name = customer.name;
            customer.name = "김더존";
        }

        public class Customer
        {
            public string name;
        }
    }
}
