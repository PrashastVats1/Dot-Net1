using System;
using System.Collections.Generic;
using System.Text;

namespace OopsConcepts2
{
    internal class StudentData
    {
        // we use < > to specify the parameter type
        //Generic class

        public class sample<T>
        {
            //field
            private T data;

            //property
            public T value
            {
                //accessors
                get
                {
                    return this.data;
                }
                set
                {
                    this.data = value;
                }

            }
            public class Student
            {
                public int StudentID { get; set; }
                public string StudentName { get; set; }
                public int Age { get; set; }
                public string Address { get; set; }
            }
            static void Main9(string[] args)
            {
                sample<string> name = new sample<string>();
                name.value = "vikash";

                sample<float> version = new sample<float>();
                version.value = 5.0F;
                //display Name
                Console.WriteLine(name.value);
                //display version
                Console.WriteLine(version.value);

                //Object Initialzier
                Student std = new Student()
                {
                    StudentID = 1,
                    StudentName = "Madhu",
                    Age = 23,
                    Address = "Dummy "
                };
                Console.WriteLine("Student Information");
                Console.WriteLine(std.StudentID);
                Console.WriteLine(std.StudentName);
                Console.WriteLine(std.Age);
                Console.WriteLine(std.Address);
            }
        }
    }
}