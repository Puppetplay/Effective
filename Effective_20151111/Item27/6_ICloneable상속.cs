using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective_20151111.Item27
{
    class _6_ICloneable상속
    {
        public void Func1()
        {
            Derived d = new Derived();
            Derived d2 = d.Clone() as Derived;
            if (d2 == null)
            {
                Console.WriteLine("null");
            }
        }
    }

    class BaseType : ICloneable
    {
        private string _label = "class name";
        private int[] _values = new int[10];

        public Object Clone()
        {
            BaseType rVal = new BaseType();
            rVal._label = _label;
            for(int i = 0; i < _values.Length; ++i)
            {
                rVal._values[i] = _values[i];
            }
            return rVal;
        }
    }

    class Derived : BaseType
    {
        private double[] _dValues = new double[10];
    }
}
