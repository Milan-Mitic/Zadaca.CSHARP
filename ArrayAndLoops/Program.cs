namespace ArraysAndLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for loop

            Console.WriteLine("The numbers in array is:\n ");
            int[] numbersArray = new int[] { 2, 5, 10, 21, 33, 48, 62, 77 };

            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.WriteLine(numbersArray[i]);
            }
            Console.WriteLine("-------------------------------------------");

            //while loop

            Console.WriteLine("The numbers in array is:\n ");
            int[] numbersArray1 = new int[] { 2, 5, 10, 21, 33, 48, 62, 77 };


            int j = 0;
            while (j < numbersArray1.Length)
            {
                Console.WriteLine(numbersArray[j]);
                j++;
            }
            Console.WriteLine("-------------------------------------------");


            //foreach loop

            Console.WriteLine("The numbers in array is:\n ");
            int[] numbersArray2 = { 2, 5, 10, 21, 33, 48, 62, 77 };

            foreach (int k in numbersArray2)
            {
                Console.WriteLine(k);
            }
        }
    }
}