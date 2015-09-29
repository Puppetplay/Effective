using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item1
{
    class _5_코드집중
    {
        private String _name;
        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                if ((value == null) || (value.Length == 0))
                {
                    throw new AggregateException("똑바로 입력해라");
                }
                else
                {
                    _name = value;
                }
            }
        }

        public void Func1()
        {
            _name = String.Empty;
        }

        public void Func2()
        {
            _name = null;
        }
    }
}
