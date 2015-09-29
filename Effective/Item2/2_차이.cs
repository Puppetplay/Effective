using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item2
{
    public class _2_차이
    {
        // const는 항상 static 이다.
        //private const DateTime now = DateTime.Now;

        private readonly DateTime now2 = DateTime.Now;

        private readonly int Number;

        private static int count = 0;

        public _2_차이()
        {
            Number = ++count;
        }
    }
}
