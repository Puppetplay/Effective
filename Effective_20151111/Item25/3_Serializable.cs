using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace Effective_20151111.Item25
{
    class _3_Serializable
    {
        public void Func1()
        {
            string xmlFilename = @"C:\temp\test.xml";
            Person person = new Person { Name = "김성효", Age = 40, Weight = 100 };

            SoapFormatter soapFmt = new SoapFormatter();
            using (FileStream fs = new FileStream(xmlFilename, FileMode.Create))
            {
                soapFmt.Serialize(fs, person);
            }

        }
    }

    [Serializable]
    public class Person
    {
        public string Name;

        private int _age;
        public int Age
        {
            get { return _age; }
            set { if (value >= 0) _age = value; }
        }

        [NonSerialized]
        private double _weight;
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

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
