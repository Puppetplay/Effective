using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Effective05.Item38
{
    class _1_NoBinding
    {
    }

    public class MyForm1 : Form
    {
        private MyType myDataValue;
        private TextBox textBoxName;

        private void InitializeComponent()
        {
            textBoxName.Text = myDataValue.Name;
            this.textBoxName.Leave += new EventHandler(this.OnLeave);
        }

        private void OnLeave(object sender, System.EventArgs e)
        {
            myDataValue.Name = textBoxName.Text;
        }

    }

    public struct MyType
    {
        public String Name { get; set; }
    }
}
