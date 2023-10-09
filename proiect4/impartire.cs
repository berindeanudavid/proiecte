using System;
class impartire
{
    static void Main()
    {
        int D,i;
        D = Convert.ToInt32(Console.ReadLine());
        i = Convert.ToInt32(Console.ReadLine());
        if(D%i == 0)
        {
            Console.WriteLine(D/i);
        }
        else
        {
            Console.WriteLine("Impartirea nu poate fi efectuata.");
        }
    }
}
