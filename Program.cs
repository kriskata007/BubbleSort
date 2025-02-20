namespace chvhbhg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
        {
            new Student("Maksim",5.32),
            new Student("Daniel", 5.87),
            new Student("Jivko", 5.57),
            new Student("Ivan", 5.87)
        };
            InsertionSortByGradeAndName(students);
            Console.WriteLine("Sorted List: ");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
        public static List<Student> InsertionSortByGradeAndName(List<Student> students)
        {
            for (int i = 1; i < students.Count; i++)
            {
                Student current = students[i];
                int j = i - 1;

                
                while (j >= 0 && (students[j].AverageGrade > current.AverageGrade ||
                                  (students[j].AverageGrade == current.AverageGrade && string.Compare(students[j].Name, current.Name) > 0)))
                {
                    students[j + 1] = students[j];
                    j--;
                }

                students[j + 1] = current;
            }

            return students;
        }
    }
}
