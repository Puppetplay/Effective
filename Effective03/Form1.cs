using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Effective03.Item19;

namespace Effective03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_3_Click(object sender, EventArgs e)
        {
            _4_CollectionBase c = new _4_CollectionBase();
            c.Func1();
        }
    }
}
