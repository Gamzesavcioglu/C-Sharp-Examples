using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId+ "  " + musteri.MusteriName + "  "+ musteri.MusteriMail +" eklendi");
            
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId + "  " + musteri.MusteriName + "  " + musteri.MusteriMail + " silindi");
        }
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriId + "  " + musteri.MusteriName + "  " + musteri.MusteriMail);
        }
    }
}
