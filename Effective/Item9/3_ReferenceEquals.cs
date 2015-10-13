using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item9
{
    class _3_ReferenceEquals
    {
        public void Func1()
        {
            int i = 5;
            int j = 5;

            bool result = Object.ReferenceEquals(i, j);
            result = Object.ReferenceEquals(i, i);
        }

        // ReferenceEquals는 재정의할 필요가 없다.
    }
}
