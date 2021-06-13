using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GerçekMusteri musteri1 = new GerçekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "12345678910";
            musteri1.Id = 1;


            //kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "544321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //Gerçek Müşteri-Tüzel müşteri
            //SOLİD

            Musteri mustri3 = new GerçekMusteri();
            Musteri msuetri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            
            1,10,
        }
    }
}
