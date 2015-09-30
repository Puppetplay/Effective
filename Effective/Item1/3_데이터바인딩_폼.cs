using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Effective.Item1
{
    public partial class _3_데이터바인딩_폼 : Form
    {
        private MyClass myClass;


        public _3_데이터바인딩_폼()
        {
            InitializeComponent();
            myClass = new MyClass();
        }

        private void btBinding_Click(object sender, EventArgs e)
        {
            tbName.DataBindings.Add("Text", myClass, "Name");
            myClass.Name = "김더존";
        }

        private void bt값확인_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myClass.Name);
        }

        private void bt값변경_Click(object sender, EventArgs e)
        {
            myClass.Name = "김성효";
        }
    }

    public class MyClass
    {
        public String Name { get; set; }
    }
}
