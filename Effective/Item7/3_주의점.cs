using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item7
{
    class _3_주의점
    {
        public void Func1()
        {
            Phone[] phones = new Phone[10];
            PhoneList pl = new PhoneList(phones);

            phones[5] = new Phone { Number = 123 };
        }
    }

    public struct PhoneList
    {
        private readonly Phone[] _phones;

        public PhoneList(Phone[] ph)
        {
            _phones = ph;
            //_phones = new Phone[ph.Length];
            //ph.CopyTo(_phones, 0);
        }

        public IEnumerator Phones
        {
            get
            {
                return _phones.GetEnumerator();
            }
        }
    }

    public class Phone
    {
        public int Number { get; set; }
    }
}
