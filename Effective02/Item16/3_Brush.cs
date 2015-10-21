using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective02.Item16
{
    class _3_Brush
    {
        private static Brush _blackBrush;

        static Brush()
        {
            _blackBrush = new SolidBrush(Color.Black);
        }

        public static Brush Black
        {
            get
            {
                if(_blackBrush == null)
                {
                    _blackBrush = new SolidBrush(Color.Black);
                }
                return _blackBrush;
            }
        }
    }
}
