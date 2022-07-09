using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Adı eklendi : " + musteri.Adi);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Tc numarası silindi : " + musteri.TcNumarasi);
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri bilgileri listelendi. " + "Müşteri Id : " + musteri.Id + " , " + "Müşteri Mesleği : " + musteri.Meslek);
        }
    }
}
