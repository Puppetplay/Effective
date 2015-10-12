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
    public partial class _4_양방향바인딩폼 : Form
    {
        private MyClass2 myClass;


        public _4_양방향바인딩폼()
        {
            InitializeComponent();
            myClass = new MyClass2();
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

    public class MyClass2 : INotifyPropertyChanged
    {
        private String name;
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != this.name)
                {
                    name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}