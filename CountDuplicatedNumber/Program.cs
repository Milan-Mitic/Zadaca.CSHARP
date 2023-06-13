namespace CountDuplicatedNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Please enter number " + (i + 1));
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i] > 100)
                {
                    break;
                }
            }
            var dict = new Dictionary<int, int>();
            foreach (var value in numbers)
            {
                if (dict.ContainsKey(value)) dict[value]++;
                else dict[value] = 1;
            }
            foreach (var pair in dict)
                Console.WriteLine("Value {0} occurred {1} times", pair.Key, pair.Value);
        }
    }
}