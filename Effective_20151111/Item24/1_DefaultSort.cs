using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective_20151111.Item24
{
    class _1_DefaultSort
    {
        public void Func1()
        {
            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer { Name = "김한호" });
            customerList.Add(new Customer { Name = "김성효" });

            IComparer<Customer> comparer = new GenericComparer<Customer>();
            customerList.Sort(comparer);
        }
    }

    [DefaultSort("Name")]
    public class Customer
    {
        private string _name;
        private decimal _balance;

        public string Name
        {
            get{ return _name; }
            set { _name = value; }
        }

        public decimal Balance
        {
            get { return _balance; }
        }

        public decimal AccountValue
        {
            get
            {
                return 10000;
            }
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class DefaultSortAttribute : System.Attribute
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DefaultSortAttribute(string name)
        {
            _name = name;
        }
    }

    // Comparer
    internal class GenericComparer<T> : IComparer<T>
    {
        private readonly PropertyDescriptor _sortProp;

        // 올림차순 혹은 내림차순
        private readonly bool _reverse = false;

        // 타입을 인자로 받는 생성자
        public GenericComparer() : this(false)
        {
        }

        // 타입과 정렬방식을 인자로 받는 생성자
        public GenericComparer(bool reverse)
        {
            _reverse = reverse;

            object[] a = typeof(T).GetCustomAttributes(typeof(DefaultSortAttribute), false);

            // 프로퍼티의 PropertyDescriptor획득
            if(a.Length > 0)
            {
                DefaultSortAttribute sortName = a[0] as DefaultSortAttribute;
                string name = sortName.Name;

                PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));

                if(props.Count > 0)
                {
                    foreach(PropertyDescriptor p in props)
                    {
                        if(p.Name == name)
                        {
                            _sortProp = p;
                            break;
                        }
                    }
                }
            }
        }

        public int Compare(T left, T right)
        {
            if ((left == null) && (right == null)) { return 0; }
            if (left == null) { return -1; }
            if (right == null) { return 1; }
            if (_sortProp == null) { return 0; }

            IComparable lField = _sortProp.GetValue(left) as IComparable;
            IComparable rField = _sortProp.GetValue(right) as IComparable;

            int rVal = 0;
            if (lField == null)
            {
                if (rField == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            rVal = lField.CompareTo(rField);
            return (_reverse) ? -rVal : rVal;
        }
    }



}
