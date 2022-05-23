using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriMethod(true, "Fatih", "Ünal", 123, 321);
            MusteriMethod(true, "Tarık", "Dursun", 234, 432);
            MusteriMethod(false, "Ayşe", "Lays", 123, 321);

        }

        private static void MusteriMethod(bool ekle, string ad, string soyad,int tc,int iban) 
        {
            MusteriManager manager = new MusteriManager();
            Musteri musteri1 = new Musteri();
            musteri1.Name = ad;
            musteri1.Surname = soyad;
            musteri1.TC = tc;
            musteri1.Iban = iban;
            if (ekle)
            {
                manager.MusteriEkle(musteri1);
            }
            else
            {
                if (manager.musteriList.Contains(musteri1))
                {
                    manager.MusteriCikar(musteri1);
                }
                else 
                {
                    Console.WriteLine("KULLANICI BULUNAMADI");
                }
            }
            manager.MusteriYazdir();
        }
        
    }
}
