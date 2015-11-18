using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Effective_20151111.Item25
{
    class _6_UnSealed
    {
    }

    [Serializable]
    public class MyType6 : ISerializable
    {
        private string _lable;
        private int _value;

        [NonSerialized]
        private int _cachedValue;

        private OtherClass _object;

        private const int DEFAULT_VALUE = 5;
        private int _value2;

        // protected 생성자(Deserialization)
        protected MyType6(SerializationInfo info, StreamingContext context)
        {
            _lable = info.GetString("_lable");
            _object = (OtherClass)info.GetValue("_object", typeof(OtherClass));
            try
            {
                _value2 = info.GetInt32("_value2");
            }
            catch
            {
                _value2 = DEFAULT_VALUE;
            }
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("_lable", _lable);
            info.AddValue("_object", _object);
            info.AddValue("_value2", _value2);
        }

        protected virtual void WriteObjectData(SerializationInfo info, StreamingContext context)
        {

        }
    }

    public class DerivedType : MyType6
    {
        private int _derivedVal;

        private DerivedType(SerializationInfo info, StreamingContext context) 
            : base(info, context)
        {
            _derivedVal = info.GetInt32("_derivedVal");
        }

        protected override void WriteObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("_derivedVal", _derivedVal);
        }
    }
}
