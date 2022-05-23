using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        //müşteri ekle
        public List<Musteri> musteriList =new List<Musteri>();
        public void MusteriEkle(Musteri musteri)
        {
            musteriList.Add(musteri);
            Console.WriteLine("Müşteri Eklendi");
        }
        public void MusteriCikar(Musteri musteri) 
        {
            musteriList.Remove(musteri);
            Console.WriteLine("Müşteri Silindi");
        }
        public void MusteriYazdir() 
        {
            foreach (Musteri musteri in musteriList)
            {
                Console.WriteLine("-" + musteri.Name + " " + musteri.Surname + " " + musteri.TC + " " + musteri.Iban);
            }
        }


    }
}
