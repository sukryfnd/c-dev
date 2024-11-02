using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi % 2 == 0)
        {
            Console.WriteLine("Girilen sayı çift.");
        }
        else
        {
            Console.WriteLine("Girilen sayı tek.");
            Console.ReadKey();
        }
    }
}
