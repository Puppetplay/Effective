using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item8
{
    class _3_Value타입초기화문제
    {
        public void Func1()
        {
            LogMessage myMessage = new LogMessage();


        }
    }

    public struct LogMessage
    {
        private int _errLevel;
        private string _msg;

        public string message
        {
            get;
            set;
        }

        public string message1
        {
            get { return (_msg != null) ? _msg : string.Empty;  }
            set { _msg = value; }
        }
    }
}
