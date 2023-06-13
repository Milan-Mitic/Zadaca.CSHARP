namespace SumOfRandomEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Press 0 to stop input value ");
                Console.WriteLine("Enter number " + (i + 1));
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i] == 0)
                {
                    break;
                }
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine("Sum of even numbers is: " + sum);
        }
    }
}