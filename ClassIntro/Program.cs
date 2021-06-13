using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adı = "engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.İzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Eğitmen = "Kerem Varış";
            kurs2.İzlenmeOranı = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Eğitmen = "Berkay Bilgin";
            kurs3.İzlenmeOranı = 80;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Eğitmen);
            }
          
            
            
            
            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Eğitmen);
           





            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }
        public int İzlenmeOranı { get; set; }
    }
}
