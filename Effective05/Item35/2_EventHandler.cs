using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Effective05.Item35
{
    class _2_EventHandler
    {
    }

    public class MyForm2 : Form
    {
        public MyForm2()
        {
            this.MouseDown += new MouseEventHandler(this.MouseDownHandler);
        }

        private void MouseDownHandler(object sender, MouseEventArgs e)
        {
            try
            {
                HandleMouseDown(e);
            }
            catch(Exception exception)
            {
                // 예외처리 루틴
            }
        }

        private void HandleMouseDown(MouseEventArgs e)
        {
        }
    }
}
