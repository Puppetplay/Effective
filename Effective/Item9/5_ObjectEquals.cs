using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item9
{
    class _5_ObjectEquals
    {
        public void Func1()
        {

        }

        public override bool Equals(object right)
        {
            if (right == null)
            {
                return false;
            }

            if(object.ReferenceEquals(this, right))
            {
                return true;
            }
           
            if(this.GetType() != right.GetType())
            {
                return false;
            }

            //return CompareFooMembers(this, right as Foo);
            return false;
        }
    }

    class Foo
    {
    }

}
