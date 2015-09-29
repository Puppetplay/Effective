using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item1
{
    class _7_Virtual
    {

    }


    // Virtual
    public class Customer
    {
        private string _name;
        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    // interface
    public interface ICustomer
    {
        object Name { get; }
        object Value
        {
            get;
            set;
        }
    }


}
