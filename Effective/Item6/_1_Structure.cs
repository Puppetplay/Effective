using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item6
{
    class _1_Structure
    {
        public void Func1()
        {
            Point a = new Point(10, 10);
            Point b = a;
            a.x = 100;
            System.Console.WriteLine(b.x);
        }

        struct Point
        {
            public int x;
            public int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
