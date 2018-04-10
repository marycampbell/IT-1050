using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Instructor
    {
        private string Name;
        private string CourseName;

        public Instructor(string name, string courseName)
        {
            this.Name = name;
            this.CourseName = courseName;
        }

        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);
        }

        public void Print()
        {
            System.Console.WriteLine("I had a teacher named " + this.Name + ".");
            System.Console.WriteLine("He taught me " + this.CourseName + ".");
            System.Console.WriteLine();
        }
    }
}
