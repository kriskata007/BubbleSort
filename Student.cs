using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chvhbhg
{
    public class Student
    {
        public string Name { get; set; }
        public double AverageGrade { get; set; }

        public Student(string name, double averageGrade)
        {
            Name = name;
            AverageGrade = averageGrade;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Average Grade: {AverageGrade}";
        }
    }
}
