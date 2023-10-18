using System;

namespace Uppgift_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal2;
            int störstTal = 0;
            string användarensVal = "";
            bool förstaLoop = true;
            do
            {
                Console.WriteLine("Skriv in ett heltal.");
                int tal1 = int.Parse(Console.ReadLine());
                if (förstaLoop)
                {
                    störstTal = tal1;
                }
                else
                    störstTal = tal1 < störstTal ? störstTal : tal1;
                förstaLoop = false;

                Console.WriteLine("Vill du skriva in ett tal till? (ja eller nej)");
                användarensVal = Console.ReadLine();

            }
            while (användarensVal != "nej");

            Console.WriteLine($"Det största talet var {störstTal}.");
            Console.ReadKey();
        }
    }
}