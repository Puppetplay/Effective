using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective_20151111.Item27
{
    class _1_ICloneable
    {
        public void Func1()
        {
        }
    }

   

    class Myclass: ICloneable
    {
        private string _label = "class name";
        private int[] _values = new int[10];

        public Object Clone()
        {
            Myclass rVal = new Myclass();

            rVal._values = _values;
            rVal._label = _label;
            for (int i = 0; i < _values.Length; ++i)
            {
                rVal._values[i] = _values[i];
            }
            return rVal;
        }
    }
}
