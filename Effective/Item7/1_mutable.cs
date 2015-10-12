using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item7_1
{
    class _1_mutable
    {
        public void Func1()
        {
            Address a1 = new Address();
            a1.Line1 = "111 S. Main";
            a1.City = "MyTown";
            a1.State = "IL";
            a1.ZipCode = 611111;

            // 수정
            a1.City = "Ann Arbor";
            a1.ZipCode = 48103;
            a1.State = "MI";
        }
    }

    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
    }
}
