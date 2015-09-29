using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item1
{
    class _9_Indexer
    {
        private string[] _strs = { "A", "B", "C" };

        public string this[int index]
        {
            get
            {
                return _strs[index];
            }
            set
            {
                _strs[index] = value;
            }
        }
    }
}
