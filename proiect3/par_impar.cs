using System;
class par_impar
{
    static void Main()
    {
        int a;
        a = Convert.ToInt32(Console.ReadLine());
        if(a%2==0)
        {
            Console.WriteLine("par");
        }
        else
        {
            Console.WriteLine("impar");
        }
    }
}
