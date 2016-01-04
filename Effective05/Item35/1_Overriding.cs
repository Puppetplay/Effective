using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Effective05.Item35
{
    class _1_Overriding
    {
    }


    public class MyForm1 : Form
    {
        protected override void OnMouseDown(MouseEventArgs e)
        {
            try
            {
                HandleMouseDown(e);
            }
            catch(Exception exception)
            {
                // 예외처리
            }
            base.OnMouseDown(e);
        }

        private void HandleMouseDown(MouseEventArgs e)
        {
        }
    }
}
