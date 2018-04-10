using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;

        public Student(string name, Instructor teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Grade = 0;
        }

        public void SetGrade(int grade)
        {
            this.Grade = grade;
        }

        public void Print()
        {
            System.Console.WriteLine(this.Name + ":");
            System.Console.WriteLine("I am a student named " + this.Name + ".");
            System.Console.WriteLine("My grade was " + this.Grade + ".");
            this.Teacher.Print();
        }



    }
}
