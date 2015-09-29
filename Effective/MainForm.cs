using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Effective.Item1;
using Effective.Item2;
using Effective.Item3;

namespace Effective
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bt1_3_Click(object sender, EventArgs e)
        {
            _3_데이터바인딩 tempClass = new _3_데이터바인딩();
            tempClass.Show();
        }

        private void bt1_4_Click(object sender, EventArgs e)
        {
            _4_양방향바인딩폼 tempClass = new _4_양방향바인딩폼();
            tempClass.Show();
        }

        private void bt1_6_Click(object sender, EventArgs e)
        {
            _6_Lock tempClass = new _6_Lock();
            tempClass.Name = "김더존";
        }

        private void bt3_1_Click(object sender, EventArgs e)
        {
            Item3._1_Cast tempClass = new _1_Cast();
            tempClass.Func2();
        }

        private void bt_3_4_Click(object sender, EventArgs e)
        {
            Item3._4_UserDefineCast tempClass = new _4_UserDefineCast();
            tempClass.Func1();
        }

        private void bt_3_6_Click(object sender, EventArgs e)
        {
            Item3._6_ValueType tempClass = new _6_ValueType();
            tempClass.Func1();
        }
    }
}
