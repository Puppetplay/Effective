using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective_20151111.Item25
{
    class _4_NonSerializalbe
    {
    }

    [Serializable]
    public class MyType3
    {
        private string _label;
        private int _value;

        [NonSerialized]
        private int _cachedValue;

        private OtherClass _object;
    }
}
