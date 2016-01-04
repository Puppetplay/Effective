using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Effective05.Item38
{
    class _2_DataBinding
    {
    }

    public class MyForm2 : Form
    {
        private MyType myDataValue;
        private TextBox textBoxName;

        private void InitializeComponent()
        {
            textBoxName.DataBindings.Add("Text", myDataValue, "Name");
        }
    }
}
