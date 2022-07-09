using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Mustafa";
            musteri1.Soyadi = "Aksoy";
            musteri1.TcNumarasi = "18000000000";
            musteri1.Meslek = "Mimar";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Berkay";
            musteri1.Soyadi = "Kaya";
            musteri2.TcNumarasi = "12000000000";
            musteri2.Meslek = "Mühendis";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Hakan";
            musteri3.Soyadi = "Yılmaz";
            musteri3.TcNumarasi = "19000000000";
            musteri3.Meslek = "Öğretmen";

            MusteriManager musteriManager = new MusteriManager();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.Ekle(musteri);
                Console.WriteLine("---------");
            }

            musteriManager.Sil(musteri2);
            Console.WriteLine("---------");
            musteriManager.Listele(musteri3);
        }
    }
}