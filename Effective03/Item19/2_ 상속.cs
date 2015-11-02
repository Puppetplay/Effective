using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective03.Item19
{
    public class BaseClass
    {
        public virtual void Run()
        {
            Console.WriteLine("BaseRun");
        }
    }

    class _2__상속 : BaseClass
    {
        public override void Run()
        {
            Console.WriteLine("Run");
        }

        public void Run2()
        {

        }
    }

    public class TestClass
    {
        public void Func1()
        {
            _2__상속 c = new _2__상속();
            c.Run();
        }
    }
}
