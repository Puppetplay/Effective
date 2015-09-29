using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item5
{
    class _2_Customer
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public void Func1()
        {
            String s = this.ToString();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
