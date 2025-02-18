namespace tihktihkt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>
        {
            new Worker("Jivko", 2),
            new Worker("Dani", 9696669),
            new Worker("Kristian", 10),
            new Worker("Maksim", 0)
        };

            
           

            List<Worker> sortedWorkers = MergeSort(workers);

            Console.WriteLine("Sorted list: ");
            foreach (Worker worker in sortedWorkers)
            {
                Console.WriteLine(worker);
            }
        }

        public static List<Worker> MergeSort(List<Worker> workers)
        {
            if (workers.Count <= 1)
                return workers;

            int mid = workers.Count / 2;
            List<Worker> left = new List<Worker>();
            List<Worker> right = new List<Worker>();

            for (int i = 0; i < mid; i++)
                left.Add(workers[i]);
            for (int i = mid; i < workers.Count; i++)
                right.Add(workers[i]);

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        public static List<Worker> Merge(List<Worker> left, List<Worker> right)
        {
            List<Worker> result = new List<Worker>();
            int leftIndex = 0, rightIndex = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (left[leftIndex].Salary <= right[rightIndex].Salary)
                {
                    result.Add(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    result.Add(right[rightIndex]);
                    rightIndex++;
                }
            }

            while (leftIndex < left.Count)
            {
                result.Add(left[leftIndex]);
                leftIndex++;
            }

            while (rightIndex < right.Count)
            {
                result.Add(right[rightIndex]);
                rightIndex++;
            }

            return result;
        }
    }
}
