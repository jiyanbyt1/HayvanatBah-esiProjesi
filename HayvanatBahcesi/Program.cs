using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    class Program
    {
        public static Hayvanlar hayvanlar = new Hayvanlar();//Hayvanlar sınıfı nesnesi
        public static AlanOlustur Alan = new AlanOlustur();//AlanOlustur sınıfı nesnesi
        public static Avlanma avlanma = new Avlanma();//Avlanma sınıfı nesnesi
        public static Kontroller ctrl = new Kontroller();//Kontroller sınıfı nesnesi
        public static AlaniYazdirma Yaz = new AlaniYazdirma();//AlaniYazdirma sınıfı nesnesi
       
        static void Main(string[] args)
        {
            Console.SetWindowSize(70, 35); //başlangıçta console boyutunu belirler
            Console.BackgroundColor = ConsoleColor.Green;//console arkaplan rengi
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;//yazı rengi
            Console.Title = "Hayvanat Bahçesi Projesi";// başlık
            Alan.Olustur();// Başlangıc olarak alan oluşturma ve hayvan yerleştirme.
            Yaz.BaslangicListesi();// ekrana yazdırma, listeleme
            while (Hareketler.hareketSayisi < 100000)//projede istenen 1000 adım koşulu
            {
                //döngümüz hayvanların hareket sayılarına göre dönecek ve hareket sayımız 1000 birimi geçtiği zaman program sonlanacaktır.
                
                ctrl.KontrolHayvanOlusturma();//kontroller alanında hayvan oluşturma alanını çağırmaktayız. bu alan 3 birim yakın aynı tür farklı cins hayvan için aynı tür hayvan oluşturacaktır.
                avlanma.Avlan();//avlanma alanını çağırmaktayız.
                ctrl.KontrolHayvanHareketi();// hayvanların hareketleri için kontroller alanından göderilecek verileri çağırmaktayız.
            }//1000 adım koşul sonu(while sonu)
            Console.WriteLine();
            Console.WriteLine("Son Liste:");
            Yaz.Listele();
            Console.WriteLine("Program Sonlandı...");
            Console.ReadKey();
        }
    }
}
