using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Effective_20151111.Item24;
using Effective_20151111.Item25;

namespace Effective_20151111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_24_1_Click(object sender, EventArgs e)
        {
            _1_DefaultSort c = new _1_DefaultSort();
            c.Func1();
        }

        private void bt25_3_Click(object sender, EventArgs e)
        {
            _3_Serializable c = new _3_Serializable();
            c.Func1();
        }
    }
}
