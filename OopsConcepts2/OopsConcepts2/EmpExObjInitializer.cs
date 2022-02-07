using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcepts2
{
    public class Employee1
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
    class EmpExObjInitializer
    {
        static void Main8(string[] args)
        {
            //Object Initialzier
            Employee1 emp = new Employee1()
            {
                EmployeeID = 1,
                EmployeeName = "Madhu",
                Age = 23,
                Address = "Hyderabad "
            };
            Console.WriteLine("Employee Information");
            Console.WriteLine(emp.EmployeeID);
            Console.WriteLine(emp.EmployeeName);
            Console.WriteLine(emp.Age);
            Console.WriteLine(emp.Address);
        }
    }
}
