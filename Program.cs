using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1000;
            musteri1.Ad = "Teoman";
            musteri1.Soyad = "Büyük";
            musteri1.KartNumarası = 657483;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1001;
            musteri2.Ad = "Ali";
            musteri2.Soyad = "Yılmaz";
            musteri2.KartNumarası = 849302;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 1002;
            musteri3.Ad = "Merve";
            musteri3.Soyad = "Demir";
            musteri3.KartNumarası = 728301;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " "+ musteri.Ad + " "+ musteri.Soyad+ " "+musteri.KartNumarası);
            }

            MusteriManager customer = new MusteriManager();
            customer.Add(musteri1);
            customer.Delete(musteri2);
            customer.List(musteri3);


        }
    }
}
