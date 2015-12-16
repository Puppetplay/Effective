using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective_20151111.Item29
{
    class _3_사용해도괜찮은경우
    {
        public void Func1()
        {
            MyWidget widget = new MyWidget();
            widget.DoWidgetThings();
        }
        
    }

    public class BaseWidget
    {
        public void DoWidgetThings()
        {

        }
    }

    public class MyWidget : BaseWidget
    {
        public new void DoWidgetThings()
        {
            // BraBraBra
        }
    }
}
