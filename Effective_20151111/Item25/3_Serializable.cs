using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective_20151111.Item25
{
    class _3_Serializable
    {
    }

    [Serializable]
    public class MyType2
    {
        private string _label;
        private int _value;
        private OtherClass _object;
    }

    public class OtherClass
    {

    }
}
