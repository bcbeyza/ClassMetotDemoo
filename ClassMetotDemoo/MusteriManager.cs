using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemoo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {

            Console.WriteLine("{0} Id nolu musteri eklendi", musteri.Id);

        }
        public void Listele(Musteri[] musteriler)
        {
            for (int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine("Musteri Id:" + musteriler[i].Id);
                Console.WriteLine("Musteri Adi: " + musteriler[i].Adi);
                Console.WriteLine("Musteri Soyadi: " + musteriler[i].Soyadi);
                Console.WriteLine("Musteri Meslegi: " + musteriler[i].Meslek);
                Console.WriteLine("Musteri Yasi: " + musteriler[i].Yasi);
                Console.WriteLine("  ");
            }




        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("{0} Id nosuna sahip musteri silinmistir.", musteri.Id);
        }































    }
}
