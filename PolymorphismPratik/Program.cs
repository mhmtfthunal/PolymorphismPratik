using System;

namespace PolymorphismPratik
{
    // Ortak Base Class
    public class BaseGeometrikSekil
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        // Sanal metod (Polymorphism için virtual)
        public virtual double AlanHesapla()
        {
            // Kare ve Dikdörtgen için varsayılan formül
            return Genislik * Yukseklik;
        }
    }

    // Kare sınıfı
    public class Kare : BaseGeometrikSekil
    {
        // Base sınıftaki AlanHesapla metodunu değiştirmiyoruz
        // Çünkü Kare için de (Genişlik x Yükseklik) formülü geçerli
    }

    // Dikdörtgen sınıfı
    public class Dikdortgen : BaseGeometrikSekil
    {
        // Dikdörtgen de aynı formülü kullanır
    }

    // Dik üçgen sınıfı
    public class DikUcgen : BaseGeometrikSekil
    {
        // Base metodunu override ediyoruz
        public override double AlanHesapla()
        {
            return (Genislik * Yukseklik) / 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Kare nesnesi
            Kare kare = new Kare { Genislik = 5, Yukseklik = 5 };

            // Dikdörtgen nesnesi
            Dikdortgen dikdortgen = new Dikdortgen { Genislik = 4, Yukseklik = 8 };

            // Dik üçgen nesnesi
            DikUcgen dikUcgen = new DikUcgen { Genislik = 6, Yukseklik = 10 };

            // Alan hesaplamaları (Polymorphism)
            Console.WriteLine($"Karenin Alanı: {kare.AlanHesapla()}");
            Console.WriteLine($"Dikdörtgenin Alanı: {dikdortgen.AlanHesapla()}");
            Console.WriteLine($"Dik Üçgenin Alanı: {dikUcgen.AlanHesapla()}");

            Console.ReadLine();
        }
    }
}
