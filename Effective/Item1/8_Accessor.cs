using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item1
{
    class _8_Accessor
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            protected set
            {
                _name = value;
            }
        }
    }
}
