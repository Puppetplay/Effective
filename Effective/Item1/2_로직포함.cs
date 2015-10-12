using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item1
{
    class _2_로직포함
    {
       // public Int32 x;
        public Int32 y;

       
        public Int32 X
        {
            get
            {
                return Y - 10;
            }
            set
            {
                y = value + 10;
            }
        }

        public Int32 Y
        {
            get
            {
                return Y; 
            }
            set
            {
                y = value;
            }
        }
    }
}
