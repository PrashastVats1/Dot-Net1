using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace OopsConcepts2
{
    class Employee
    {
        string sal,eid;
        public void Input()
        {
            sal = Console.ReadLine();
            eid = Console.ReadLine();
        }
        public void Salary()
        {
            Regex re = new Regex("^[0-9]{5,6}$");
            Match match = re.Match(sal);
        }
        public void EmpID()
        {
            Regex re1 = new Regex("^[A-Z]{3} [0-9]{3}$");
            Match match1 = re1.Match(eid);
        }
        public void Output()
        {
            Console.WriteLine("Salary is "+ sal);
            Console.WriteLine("EmpID is " + eid);
        }

    }
    class EmployeeRegex
    {
        static void Main4(string[] args)
        {
            Console.Write("Enter Name->");
            Console.ReadLine();
            Console.WriteLine("Enter Salaray");
            Console.WriteLine("Enter Employee ID");
            Employee emp = new Employee();
            emp.Input();
            emp.Salary();
            emp.EmpID();
            emp.Output();
        }
    }
}
