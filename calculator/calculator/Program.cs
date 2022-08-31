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
            int erotus = x - y;

            Console.WriteLine("summa vai erotus?");

            string vastaus = Console.ReadLine();

            if (vastaus == "summa")
            {
                Console.WriteLine(sum);
            } else if (vastaus == "erotus")
            {
                Console.WriteLine(erotus);
            }
        }
    }
}
