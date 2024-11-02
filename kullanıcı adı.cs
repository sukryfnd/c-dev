using System;

class Program
{
    static void Main()
    {
        // Doğru kullanıcı adı ve şifre
        string dogruKullaniciAdi = "admin";
        string dogruSifre = "Admin_32453@";

        // Kullanıcıdan giriş bilgilerini alıyoruz
        Console.Write("Kullanıcı adını girin: ");
        string kullaniciAdi = Console.ReadLine();

        Console.Write("Şifreyi girin: ");
        string sifre = Console.ReadLine();

        // Kullanıcı adı ve şifre kontrolü
        if (kullaniciAdi == dogruKullaniciAdi && sifre == dogruSifre)
        {
            Console.WriteLine("Giriş başarılı!");
        }
        else
        {
            Console.WriteLine("Giriş başarısız. Lütfen tekrar deneyin.");
        }
    }
}
