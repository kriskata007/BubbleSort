using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class University
    {
        private List<Student> students;

        public University()
        {
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            students.Sort((s1, s2) => s1.Score.CompareTo(s2.Score));
        }

        public string FindStudentByScore(int score)
        {
            int index = BinarySearch(students, score);
            if (index != -1)
            {
                return students[index].Name;
            }
            return "Not sorted";
        }

        private int BinarySearch(List<Student> students, int score)
        {
            int left = 0;
            int right = students.Count - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (students[mid].Score == score)
                {
                    return mid;
                }

                if (students[mid].Score < score)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}


