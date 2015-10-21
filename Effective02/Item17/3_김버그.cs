using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective02.Item17
{
    class _3_김버그
    {
        public void Func1()
        {
            ArrayList attendees = new ArrayList();
            Person p = new Person("Old Name");
            attendees.Add(p);

            Person p2 = ((Person)attendees[0]);
            p2.Name = "New Name";
        }
    }

    public struct Person
    {
        private string _name;

        public Person(string name)
        {
            _name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
