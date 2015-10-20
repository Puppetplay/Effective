using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective02.Item14
{
    class _2_잘못된방법
    {
        private ArrayList _coll;
        private string _name;

        public _2_잘못된방법()
        {
            commonConstructor(0, "");
        }

        public _2_잘못된방법(int initialCount)
        {
            commonConstructor(initialCount, "");
        }

        public _2_잘못된방법(int initialCount, string name)
        {
            commonConstructor(initialCount, name);
        }

        private void commonConstructor(int initialCount, string name)
        {
            _coll = (initialCount > 0) ? new ArrayList(initialCount) : new ArrayList();
            _name = name;
        }
    }

    public class MyClass
    {
        private ArrayList _coll;
        private readonly string _name;

        public MyClass()
        {
            commonConstructor(0, "");
        }

        public MyClass(int initialCount)
        {
            commonConstructor(initialCount, "");
        }

        private void commonConstructor(int initialCount, string name)
        {
            _coll = (initialCount > 0) ? new ArrayList(initialCount) : new ArrayList();
            //_name = name;
        }
    }
}
