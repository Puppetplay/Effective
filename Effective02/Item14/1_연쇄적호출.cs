using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective02.Item14
{
    class _1_연쇄적호출
    {
        private ArrayList _coll;
        private string _name;

        public _1_연쇄적호출() :
            this(0, "")
        {

        }

        public _1_연쇄적호출(int initialCount) :
            this(initialCount, "")
        {

        }

        public _1_연쇄적호출(int initialCount, string name)
        {
            _coll = (initialCount > 0) ?
                new ArrayList(initialCount) : new ArrayList();
            _name = name;
        }
    }
}
