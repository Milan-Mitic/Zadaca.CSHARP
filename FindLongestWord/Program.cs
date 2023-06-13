namespace FindLongestWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] msgArray = { "Send data", "Message arr", "Calculate data", "SEDC Code Academy C# basic", "Play" };

            int i = 0;
            string longString = msgArray[i];

            foreach (string word in msgArray)
            {
                if (longString.Length < word.Length)
                    longString = word;
            }
            Console.WriteLine("The longest word: " + longString);
            Console.WriteLine("Letters count: " + longString.Length);
        }
    }
}