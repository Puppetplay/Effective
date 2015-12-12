using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective_20151111.Item26
{
    class _1_IComparable
    {
        public void Func1()
        {
            Customer c1 = new Customer("Babo");
            Employee e1 = new Employee();
            if (c1.CompareTo(e1) > 0)
            {

            }

            Customer2 c2 = new Customer2("Babo");
            Employee e2 = new Employee();
            //if (c2.CompareTo(e2) > 0)
            //{

            //}
        }
            
    }

    public struct Employee
    {

    }

    public struct Customer : IComparable
    {
        private readonly string _name;

        public Customer(String name)
        {
            _name = name;
        }

        // IComarable 인터페이스
        public int CompareTo(object right)
        {
            if(!(right is Customer))
            {
                throw new ArgumentException("Argument not a customer", "right");
            }

            Customer rightCustomer = (Customer)right;
            return _name.CompareTo(rightCustomer._name);
        }

        // 정렬시간 평균 N X Log(n) = N x log(n) = 7000
        // 7000 * 3 -> 20000번 이상의 Boxing, UnBoxing
    }

    public struct Customer2 : IComparable
    {
        private string _name;

        public Customer2(string name)
        {
            _name = name;
        }

        int IComparable.CompareTo(object right)
        {
            if (!(right is Customer))
            {
                throw new ArgumentException("Argument not a customer", "right");
            }

            Customer2 rightCustomer = (Customer2)right;
            return CompareTo(rightCustomer);
        }

        public int CompareTo(Customer2 right)
        {
            return _name.CompareTo(right._name);
        }
    }
}
