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
using Effective.Item4;
using Effective.Item5;
using Effective.Item6;
using Effective.Item8;
using Effective.Item9;

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
            _1_Cast tempClass = new _1_Cast();
            tempClass.Func2();
        }

        private void bt_3_4_Click(object sender, EventArgs e)
        {
            _4_UserDefineCast tempClass = new _4_UserDefineCast();
            tempClass.Func1();
        }

        private void bt_3_6_Click(object sender, EventArgs e)
        {
            _6_ValueType tempClass = new _6_ValueType();
            tempClass.Func1();
        }

        private void bt_4_1_Click(object sender, EventArgs e)
        {
            _1_If tempClass = new _1_If();
            tempClass.Func1();
        }

        private void bt_4_3_Click(object sender, EventArgs e)
        {
            _3_ConditionalAttribute tempClass = new _3_ConditionalAttribute();
            tempClass.Func1();
        }

        private void bt5_2_Click(object sender, EventArgs e)
        {
            _2_Customer tempClass = new _2_Customer();
            tempClass.Name = "김더존";
            tempClass.Func1();
        }

        private void bt5_3_Click(object sender, EventArgs e)
        {
            _3_Customer tempClass = new _3_Customer
            {
                Name = "김더존",
                PhoneNumber = "0101111111"
            };
            string s = String.Format(new CustomFormatter(), "{0}", tempClass);
        }

        private void bt6_1_Click(object sender, EventArgs e)
        {
            _1_Structure tempClass = new _1_Structure();
            tempClass.Func1();
        }

        private void bt6_2_Click(object sender, EventArgs e)
        {
            _2_Reference tempClass = new _2_Reference();
            tempClass.Func1();
        }

        private void bt6_3_Click(object sender, EventArgs e)
        {
            Effective.Item6_3._3_값타입의장점 tempClass = new Effective.Item6_3._3_값타입의장점();
            tempClass.Func1();
        }

        private void bt6_4_Click(object sender, EventArgs e)
        {
            Effective.Item6_4._4_참조타입의장점 tempClass = new Effective.Item6_4._4_참조타입의장점();
            tempClass.Func1();
        }

        private void bt8_1_Click(object sender, EventArgs e)
        {
            _1_Enum tempClass = new _1_Enum();
            tempClass.Func1();
        }

        private void bt9_3_Click(object sender, EventArgs e)
        {
            _3_ReferenceEquals tempClass = new _3_ReferenceEquals();
            tempClass.Func1();
        }
    }
}
