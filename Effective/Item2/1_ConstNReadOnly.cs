using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item2
{
    class _1_ConstNReadOnly
    {
        public const int _Millennium = 2000;

        public readonly int _ThisYear;
        static int cnt = 1;

        _1_ConstNReadOnly()
        {
            _ThisYear = cnt++;
        }
    }
}
