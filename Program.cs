namespace njfrfr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList dll = new DoublyLinkedList();

            Console.WriteLine("Write the count of the numbers in this List: ");
            int numberOfElements = int.Parse(Console.ReadLine());

            Console.WriteLine("Fill the List with numbers: ");
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.Write($"Element {i + 1}: ");
                int value = int.Parse(Console.ReadLine());
                dll.AddToEnd(value);
            }

            Console.WriteLine("First List: ");
            dll.PrintList();

            dll.Reverse();

            Console.WriteLine("Reversed List: ");
            dll.PrintList();
        }
    }
}
