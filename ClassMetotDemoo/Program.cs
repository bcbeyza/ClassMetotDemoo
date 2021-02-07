using System;

namespace ClassMetotDemoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 333333333;
            musteri1.Adi = "Mavi";
            musteri1.Soyadi = "D* ";
            musteri1.Meslek = "Muhendis";
            musteri1.Yasi = 44;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1111111;
            musteri2.Adi = "Ayse";
            musteri2.Soyadi = "B* ";
            musteri2.Meslek = "Sporcu";
            musteri2.Yasi = 33;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Meslek);
                Console.WriteLine(musteri.Yasi);
                Console.WriteLine(" ");



            }



            Console.WriteLine("------------Metot ile Yapim------------------");

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);

            musteriManager.Ekle(musteri2);

            Console.WriteLine("*****************************************");

            musteriManager.Listele(musteriler);

            Console.WriteLine("*****************************************");

            musteriManager.Sil(musteri1);

            musteriManager.Sil(musteri2);

            Console.WriteLine("********************************************");

        }
    }
}
