using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Effective02.Item16
{
    class _2_올바른사용
    {
        private readonly Font _myFont = new Font("Arial", 10.0f);

        protected void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawString(DateTime.Now.ToString(), _myFont, null, new PointF());
        }
    }
}
