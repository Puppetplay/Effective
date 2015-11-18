using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective_20151111.Item27
{
    class _7_복사생성자
    {
        public void Func1()
        {
            Derived2 d = new Derived2();
            Derived2 d2 = d.Clone() as Derived2;
            if (d2 == null)
            {
                Console.WriteLine("null");
            }
        }
    }

    class BaseType2 
    {
        private string _label = "class name";
        private int[] _values = new int[10];

        protected BaseType2()
        {
            _label = "class name";
            _values = new int[10];
        }
        protected BaseType2(BaseType2 right)
        {
            _label = right._label;
            _values = right._values.Clone() as int[];
        }
    }

    sealed class Derived2 : BaseType2, ICloneable
    {
        private double[] _dValues = new double[10];

        public Derived2()
        {
            _dValues = new double[10];
        }

        private Derived2(Derived2 right) : base(right)
        {
            _dValues = right._dValues.Clone() as double[];
        }

        public object Clone()
        {
            Derived2 rVal = new Derived2(this);
            return rVal;
        }
    }
}
