namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];

            Console.WriteLine("Enter 6 numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine("Sum of even numbers: " + sum);
        }
    }
}