using System;

namespace inluppg4_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bestäm kvadraternas sidlängd");
            int sideWidth = int. Parse(Console.ReadLine());
            Console.WriteLine("Bestäm rutäntets bredd");
            int gridWidth = int.Parse(Console.ReadLine());
            Console.WriteLine("Bestäm rutnätets höjd");
            int gridHeight = int.Parse(Console.ReadLine());

            for (int  i = 0; i < gridHeight; i++)
            {
                for (int va = 0; va < sideWidth; va++)
                {
                    for (int j = 0; j < gridWidth; j++)
                    {
                        for (int k = 0; k < sideWidth; k++)
                        {
                            Console.Write('*');
                        }
                        Console.Write(' ');
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}