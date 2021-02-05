using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Çolak";
            musteri1.Numara = 145675789;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Mustafa";
            musteri2.Soyad = "Bozan";
            musteri2.Numara = 654679432;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Mert";
            musteri3.Soyad = "Yozgat";
            musteri3.Numara = 654789109;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Ad = "Ali";
            musteri4.Soyad = "Aras";
            musteri4.Numara = 654654654;

            Musteri musteri5 = new Musteri();
            musteri5.Id = 5;
            musteri5.Ad = "Yasin";
            musteri5.Soyad = "Özkök";
            musteri5.Numara = 343754075;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };

            Console.WriteLine("*************************************MÜŞTERİLER****************************************************");
            foreach (Musteri ekli in musteriler)
            {
                Console.WriteLine("\n" + "Müşteri Sırası:" + ekli.Id + " " + "Müşteri Ad:" + ekli.Ad + " " + "Müşteri Soyad:" + ekli.Soyad + " " + "Müsteri Numarası:" + ekli.Numara);
            }

            MusteriManager musteri = new MusteriManager();

            Console.WriteLine("\n" + "*********************************MÜŞTERİ EKLEME**************************");
            musteri.Add(musteri1);
            musteri.Add(musteri2);

            Console.WriteLine("\n" + "************************************MÜŞTERİ SİLME**********************************");
            musteri.Delete(musteri3);
            musteri.Delete(musteri4);
            Console.ReadLine();
        }
    }
}
