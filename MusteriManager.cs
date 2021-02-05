using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("\n" + "Yeni Müşteri Eklendi:" + "\n" + "Verilen ID:" + musteri.Id + "\n" + "Ad Ve Soyad:" + musteri.Ad + " " + musteri.Soyad + " " + "\n" + "Müşteri Numarası:" + musteri.Numara);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Silinen Müşteri:" + "\n" + musteri.Ad + " " + musteri.Soyad + "\n" + "Müşteri Numarası:" + musteri.Numara);
        }
        public void List(Musteri musteri)
        {
            Console.WriteLine("Kayıtlı Müşteriler:" + "\n" + "ID Numarası:" + musteri.Id + "\n" + "Ad Ve Soyad:" + musteri.Ad + musteri.Soyad + "\n" + "Müşteri Numarası:" + musteri.Numara);
        }
    }
}