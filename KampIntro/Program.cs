using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safeti = tip güvenliği
            //Do not repeat yourself = kendini tekrarlama
            //değer tutucu alias

            string kategoriEtiketi = "kategoriler";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirişYapmışMı = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            
            
            else
            {
                Console.WriteLine("değişmedi butonu");
            }


            if (sistemeGirişYapmışMı == true)
            {
                Console.WriteLine("Kulanıcı ayarları butonu");



            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);


        }
    }
}
