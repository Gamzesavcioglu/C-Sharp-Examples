using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double Id;
            int girdi;
            MusteriManager musteriManager = new MusteriManager();
            List<Musteri> musteriler = new List<Musteri>();

            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 25485566852;
            musteri1.MusteriName = "Ali Sözen";
            musteri1.MusteriMail = "alisozen@gmail.com";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 27851652255;
            musteri2.MusteriName = "Gamze Savcıoğlu";
            musteri2.MusteriMail = "gamze@gmail.com";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 7854329526;
            musteri3.MusteriName = "Eren Söke";
            musteri3.MusteriMail = "erensk@gmail.com";


            musteriManager.MusteriEkle(musteri1);
            musteriler.Add(musteri1);
            
            musteriManager.MusteriEkle(musteri2);
            musteriler.Add(musteri2);
           
            musteriManager.MusteriEkle(musteri3);
            musteriler.Add(musteri3);


            Console.Write("Musteri silmek için 1'e basin: ");
            girdi = Convert.ToInt32(Console.ReadLine());
            if(girdi == 1)
            {
                Console.Write("Silmek istediğiniz müsteri Id girin: ");
                Id = Convert.ToDouble(Console.ReadLine());
                Musteri deger = musteriler.Find(i => i.MusteriId == Id);

                if (musteriler.Contains(deger))
                {
                    musteriManager.MusteriSil(deger);
                    musteriler.Remove(deger);

                }

                Console.WriteLine("---MUSTERİ LİSTESİ----");

                foreach (Musteri x in musteriler)
                {
                    musteriManager.MusteriListele(x);

                }


            }
            else
            {
                Console.WriteLine("---MUSTERİ LİSTESİ----");

                foreach (Musteri x in musteriler)
                {
                    musteriManager.MusteriListele(x);

                }

            }


           









        }
    }
}
