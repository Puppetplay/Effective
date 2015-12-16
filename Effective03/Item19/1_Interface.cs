using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective03.Item19
{
    public interface IRunable
    {
        int a { set; get; }
        void Run();
    }

    class _1_Interface : IRunable
    {
        public int a
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Run()
        {
            Console.WriteLine("Run");
        }
    }

    public class Test_3 : IEnumerable<int>
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class Test_4
    {
        public void Func1()
        {
            foreach(var i in new Test_3())
            {

            }
        }
    }

}
