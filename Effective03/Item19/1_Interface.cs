using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective03.Item19
{
    public interface IRunable
    {
        void Run();
    }

    class _1_Interface : IRunable
    {
        public void Run()
        {
            Console.WriteLine("Run");
        }
    }
}
