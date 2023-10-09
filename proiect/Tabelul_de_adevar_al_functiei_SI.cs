using System;

class Program
{
    static void Main()
    {
    Console.WriteLine("Tabel de adevar pentru operatorul AND pe biti:");
    Console.WriteLine("x\ty\tAND");
    Console.WriteLine("----------------------");
    for(int x = 0;x <= 1;x++)
        {
        for(int y = 0; y <= 1 ; y++)
            {
            bool result = (x&y) == 1;
            Console.WriteLine($"{x}\t{y}\t{result}");
            }
        }

    }
}
