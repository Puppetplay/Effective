using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective03.Item21
{
    public class TestClass
    {
        public delegate bool ContinueProcessing();

        public void LengthOperation(ContinueProcessing pred)
        {
            while(true)
            {
                if(pred() == false)
                {
                    break;
                }
            }
        }

        public void LengthOperation2(ContinueProcessing pred)
        {
            bool bContinue = true;
            while (true)
            {
                foreach(ContinueProcessing pr in pred.GetInvocationList())
                {
                    bContinue &= pr();
                }
                if(false == bContinue)
                {
                    break;
                }
            }
        }

        private bool IsComplete()
        {
            if(1 == 1) // 일이 끝났으면
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsComplete2()
        {
            if (1 == 1) // 일이 끝났으면
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Func1()
        {
            ContinueProcessing cp = new ContinueProcessing(IsComplete);
            cp += new ContinueProcessing(IsComplete2);
            LengthOperation(cp);
        }

    }
}
