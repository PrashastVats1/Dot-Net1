using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    //what a class can have

    //constructor and destructor
    //fields and constants
    //Methods
    //Properties
    //Indexers
    //overloaded operators
    //Nested types
    //--classes and structs
    //--intrefaces
    //--enumerations
    //--Delegates
    //--events
    class Sample
    {
        //fields
        int a;
        //internal
        //public
        //method
        public void display()
        {
            Console.WriteLine(a);
        }
        public void GetValue()
        {
            Console.WriteLine("Please enter the value of a:");
            a = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Employee
    {
        int EmployeeID;
        string EmployeeName;
        double EmployeeSalary;
        string EmployeeGender;

        public void GetEmployeeInformation()
        {
            Console.WriteLine("Please enter employee Id");
            EmployeeID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter employee Name");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("Please enter employee Salary");
            EmployeeSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter employee Gender");
            EmployeeGender = Console.ReadLine();
        }

        public void ShowEmployeeData()
        {
            Console.WriteLine("Employee Data :-");
            Console.WriteLine("Employee Id : {0}", EmployeeID);
            Console.WriteLine("Employee Name : {0}", EmployeeName);
            Console.WriteLine("Employee Salary : {0}", EmployeeSalary);
            Console.WriteLine("Employee Gender : {0}", EmployeeGender);


        }
    }
    class DataEmployee
    {
        static void Main12(string[] args)
        {

            //Sample SamepleObject = new Sample();
            //SamepleObject.GetValue();
            //SamepleObject.display();

            Employee[] employee = new Employee[2];

            for (int i = 0; i < employee.Length; i++)
            {
                Employee employee1 = new Employee();
                employee1.GetEmployeeInformation();
                employee[i] = employee1;
            }
            for (int i = 0; i < employee.Length; i++)
            {
                employee[i].ShowEmployeeData();
            }

            Console.WriteLine("Hello World!");
        }
    }
}
