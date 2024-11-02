using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan sıcaklık değeri alıyoruz
        Console.Write("Sıcaklık değerini girin: ");
        int sicaklik = int.Parse(Console.ReadLine());

        // Sıcaklık durumunu kontrol eden if-else yapısı
        if (sicaklik >= 10 && sicaklik < 20)
        {
            Console.WriteLine("Normal");
        }
        else if (sicaklik >= 20 && sicaklik < 30)
        {
            Console.WriteLine("Sıcak");
        }
        else if (sicaklik >= 30 && sicaklik <= 40)
        {
            Console.WriteLine("Çok Sıcak");
        }
        else
        {
            Console.WriteLine("Geçersiz sıcaklık aralığı.");
        }
    }
}
