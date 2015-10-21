using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item8
{
    class _2_Flags
    {
        public void Func1()
        {
            Styles style = Styles.Sunken;

            // Flat이 0일때와 1일때
            if ((style & Styles.Flat) != 0)
            {

            }
        }
    }

    [Flags]
    public enum Styles
    {
        None = 0,
        Flat = 1,
        Sunken = 2,
        Raised = 4
    }
}
