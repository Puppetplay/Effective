using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item1
{
    class _6_Lock
    {
        private String _name;
        public String Name
        {
            get
            {
                lock(this)
                {
                    return _name;
                }
            }
            set
            {
                lock(this)
                {
                    _name = value;
                    Name2 = value;
                }
            }
        }

        private String _name2;
        public String Name2
        {
            get
            {
                lock (this)
                {
                    return _name2;
                }
            }
            set
            {
                lock (this)
                {
                    _name2 = value;
                }
            }
        }
    }
}
