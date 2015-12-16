using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective_20151111.Item27
{
    class _5__valueNReference
    {
        void Func1()
        {
            ErrorMessage L = new ErrorMessage();
            ErrorMessage L2 = L;
        }
    }

    public struct ErrorMessage
    {
        private int errCode;
        private int details;
    }
}
