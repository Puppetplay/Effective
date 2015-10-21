using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Effective02.Item16
{
    class _1_잘못된사용
    {
        protected void OnPaint(PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 10.0f))
            {
                e.Graphics.DrawString(DateTime.Now.ToString(), myFont, Brushes.Black, new PointF());
            }
        }
    }
}
