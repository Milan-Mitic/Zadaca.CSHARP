namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Milan", "Biljana", "Vitomir", "Attila", "Dalibor" };
            string[] studentsG2 = { "David", "Miroslav", "Igor", "Marko", "Nikola" };

            Console.WriteLine("Please enter 1 for G1 or 2 for G2: ");
            int groupNumber = int.Parse(Console.ReadLine());

            if (groupNumber == 1)
            {
                Console.WriteLine("The students in G1 are:\n ");
                foreach (string student in studentsG1)
                {
                    Console.WriteLine(student);
                }
            } else 
            if (groupNumber == 2)
            {
                Console.WriteLine("The students in G2 are:\n ");
                foreach (string student in studentsG2)
                {
                    Console.WriteLine(student);
                }
            }  else
            {
                Console.WriteLine("Wrong number !!! Please enter 1 or 2");
            }   
        }
    }
}