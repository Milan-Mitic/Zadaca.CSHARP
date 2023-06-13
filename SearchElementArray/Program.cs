namespace SearchElementArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 12, 20, 33, 45, 58 };

            Console.WriteLine("Enter number");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            bool containsNumber = numbers.Contains(searchNumber);

            if (containsNumber)
            {
                Console.WriteLine("The number exist");
            }
            else
            {
                Console.WriteLine("The number does not exist");
            }
        }
    }
}