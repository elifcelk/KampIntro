using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("BU BİLGİLER D&R SİTESİNDEN ALINMIŞTIR\n\n");

            Urun urun1 = new Urun();
            Urun urun2 = new Urun();
            Urun urun3 = new Urun(); 

            urun1.Kategori = "Edebiyat";
            urun1.KitapAdi = "Hayvan Çiftliği";
            urun1.Yazari = "George Orwell";
            urun1.Yayınevi = "Can Yayınları";
            urun1.Fiyatı = 7.70;

            urun2.Kategori = "Araştırma-Tarih";
            urun2.KitapAdi = "Nutuk";
            urun2.Yazari = "Mustafa Kemal Atatürk";
            urun2.Yayınevi = "İş Bankası Kültür Yayınları";
            urun2.Fiyatı = 12.60;

            urun3.Kategori = "Çizgi Roman";
            urun3.KitapAdi = "Suikast Sınıfı 1";
            urun3.Yazari = "Yusei Matsui";
            urun3.Yayınevi = "Gerekli Şeyler";
            urun3.Fiyatı = 16.80;

            Urun[] urunler = new Urun[] {urun1,urun2,urun3 }; //dizi oluşturdum.

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Kategori:"+urun.Kategori+"\n" +"Kitap Adi:"+urun.KitapAdi + "\n" + "Yazari:"+urun.Yazari + "\n" + "Yayınevi:"+urun.Yayınevi + "\n" + "Fiyati:"+urun.Fiyatı + "\n" + "\n");

            }

            Console.WriteLine("***foreach bitti.***\n\n");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Kategori:" + urunler[i].Kategori + "\n" + "Kitap Adi:" + urunler[i].KitapAdi + "\n" + "Yazari:" + urunler[i].Yazari + "\n" + "Yayınevi:" + urunler[i].Yayınevi + "\n" + "Fiyati:" + urunler[i].Fiyatı + "\n" + "\n");

            }
            Console.WriteLine("***for bitti***\n\n");

            int deger = 0;
            while (deger < urunler.Length)

            {
                Console.WriteLine("Kategori:" + urunler[deger].Kategori + "\n" + "Kitap Adi:" + urunler[deger].KitapAdi + "\n" + "Yazari:" + urunler[deger].Yazari + "\n" + "Yayınevi:" + urunler[deger].Yayınevi + "\n" + "Fiyati:" + urunler[deger].Fiyatı + "\n" + "\n");
                deger++;

            }  
            Console.WriteLine("***while bitti***\n\n");








        }
    }

    class Urun
    {
        public string Kategori { get; set; }

        public string KitapAdi  { get; set; }
        public string Yazari { get; set; }
        public string Yayınevi { get; set; }
        public double Fiyatı { get; set; }
        


    }
}
