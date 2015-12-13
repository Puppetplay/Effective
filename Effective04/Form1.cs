using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Effective04.Item30;

namespace Effective04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt30_1_Click(object sender, EventArgs e)
        {
            _2_CLSCompliant cls = new _2_CLSCompliant();
            cls.TheProperty = new Effective04_Dll.MyClass();
        }
    }
}
