namespace bhvfbhdvbvnbdjjvn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Jivko", 17),
                new Student("Elena", 27),
                new Student("Maksim", 40),
                new Student("Kristian", 12)
            };
            Console.WriteLine("Enter student's names:");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
            Bubble(students);
            Console.WriteLine("The new list is: ");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
        public static void Bubble(List<Student> students)
        {
            int n = students.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (students[j].Age > students[j + 1].Age)
                    {

                        Student temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                    }
                }
            }
        }
    }
}
