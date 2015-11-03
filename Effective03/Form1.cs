using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Effective03.Item22;
using Effective03.Item22_2;

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
            TestClass01 testClass = new TestClass01();
            testClass.Func1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestClass02 testClass = new TestClass02();
            testClass.Func1();
        }
    }
}
