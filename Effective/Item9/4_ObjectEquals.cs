using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item9
{
    class _4_ObjectEquals
    {
        public void Func1()
        {

        }

        // 요런식으로 구현되어있다.
        public static bool Equals(object left, object right)
        {
            if(left == right)
            {
                return true;
            }

            if((left == null) || (right == null))
            {
                return false;
            }

            return left.Equals(right);
        }
    }
}
