using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item1
{
    class _1_NET4
    {
        public void Func1()
        {
            var customer = new Customer2()
            {
                Name = "성효",
                age = 1
            };
        }
    }

    public class Customer2
    {
        public string Name { get; set; }
        public int age { get; set; }
    }
}
