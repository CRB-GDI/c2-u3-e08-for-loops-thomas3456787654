namespace Execise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter maximum number: ");
            int number = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                //for loop body
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }

            //asterisk
            Console.WriteLine("How many of asterisk? ");
            int astNum = Int32.Parse(Console.ReadLine());

            for (int a = 0; a < astNum; a++)
            {
                Console.Write("*");
            }

            //Console.WriteLine(number);
        }
    }
}