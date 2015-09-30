using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item2
{
    class _4_Const의활용
    {
        private const int VERSION_1_0 = 100;
        private const int VERSION_1_1 = 101;
        private const int VERSION_1_2 = 102;

        private static readonly int CURRENT_VERSION = VERSION_1_2;

        public void Run()
        {
            switch(CURRENT_VERSION)
            {
                case VERSION_1_0:

                    break;
                case VERSION_1_1:
                    break;
                case VERSION_1_2:
                    break;
                default:
                    break;
            }
        }
    }
}
