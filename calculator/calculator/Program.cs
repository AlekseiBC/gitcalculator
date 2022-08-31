using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            int sum = x + y;

            Console.WriteLine(sum);
        }
    }
}
