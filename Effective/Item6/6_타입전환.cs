using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Effective.Item6
{
    class _6_타입전환
    {
        public void Func1()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee());
            Employee e1 = employees[0];
            e1.Salary += 10; // 보너스
            e1.Pay(new BankAccount());
        }
    }

    //public class Employee
    public struct Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public decimal Salary { get; set; }

        public void Pay(BankAccount b)
        {
            b.Balance += Salary;
        }
    }

    public class BankAccount
    {
        public decimal Balance
        {
            get; set;
        }
    }
}
