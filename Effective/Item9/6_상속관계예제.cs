using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item9
{
    class _6_상속관계예제
    {
        public void Func1()
        {
            B baseObject = new B();
            D derivedObject = new D();

            // 비교 1
            bool result = baseObject.Equals(derivedObject);

            // 비교 2
            result = derivedObject.Equals(baseObject);
        }
    }

    public class B
    {
        public override bool Equals(object right)
        {
            if(right == null)
            {
                return false;
            }

            if(object.ReferenceEquals(this, right))
            {
                return true;
            }

            B rightAsB = right as B;
            if(rightAsB == null)
            {
                return false;
            }

            return CompareBMembers(this, rightAsB);
        }

        private bool CompareBMembers(B b, B rightAsb)
        {
            throw new Exception();
        }
    }

    public class D : B
    {
        public override bool Equals(object right)
        {
            if (right == null)
            {
                return false;
            }

            if (object.ReferenceEquals(this, right))
            {
                return true;
            }

            // !!!!
            D rightAsD = right as D;
            if(rightAsD == null)
            {
                return false;
            }

            if(base.Equals(rightAsD) == false)
            {
                return false;
            }

            return CompareDMembers(this, rightAsD);
        }

        private bool CompareDMembers(D d, object rightAsD)
        {
            return true;
        }
    }
}
