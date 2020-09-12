using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    //BU SINIFTA YAZDIRMA VE LİSTELEME İŞLEMLERİ YAPILMAKTADIR.
    public class AlaniYazdirma
    {
        public static Hayvanlar hayvanlar = new Hayvanlar();//hayvan bilgilerini Hayvanlar sınıfından çekeceğimiz bir nesne

        public void Listele()
        {//ekrana çıkan sonuçları yazdırmak için kullanılan metod
            int sayac = 0;//*
            int sayackoyun = 0;//*
            int sayackurt = 0;//*
            int sayacinek = 0;//*
            int sayactavuk = 0;//*
            int sayachoroz = 0;//*
            int sayacaslan = 0;//*
            int sayacavci = 0;//*
            //* değerler her bir hayvan için adet sayısını tutacağımız değişkenler
            for (int i = 0; i < 500; i++)
            {//2 boyutlu dizinin satır boyunca dönecek döngü
                for (int j = 0; j < 500; j++)
                {//2 boyutlu dizinin sütun boyunca dönecek döngü
                    if (AlanOlustur.alan[i, j] != 0)//eğer gelen değerler boş değilse(0 dışında bir id numarası)
                    {
                        if (AlanOlustur.alan[i, j] == 1.1 || AlanOlustur.alan[i, j] == 1.2)//eğer 1. sayının erkek veya dişisi(0.1,0.2)
                            sayackoyun++;//koşul sağlandığı zaman sayacı tek tek arttır
                        else if (AlanOlustur.alan[i, j] == 2.1 || AlanOlustur.alan[i, j] == 2.2)//eğer 2. sayının erkek veya dişisi(0.1,0.2)
                            sayackurt++;//koşul sağlandığı zaman sayacı tek tek arttır
                        else if (AlanOlustur.alan[i, j] == 3.1 || AlanOlustur.alan[i, j] == 3.2)//eğer 3. sayının erkek veya dişisi(0.1,0.2)
                            sayacinek++;//koşul sağlandığı zaman sayacı tek tek arttır
                        else if (AlanOlustur.alan[i, j] == 4)//eğer id sayısı 4 ise
                            sayactavuk++;//koşul sağlandığı zaman sayacı tek tek arttır
                        else if (AlanOlustur.alan[i, j] == 5)//eğer id sayısı 5 ise
                            sayachoroz++;//koşul sağlandığı zaman sayacı tek tek arttır
                        else if (AlanOlustur.alan[i, j] == 6.1 || AlanOlustur.alan[i, j] == 6.2)//eğer 4. sayının erkek veya dişisi(0.1,0.2)
                            sayacaslan++;//koşul sağlandığı zaman sayacı tek tek arttır
                        else if (AlanOlustur.alan[i, j] == 7)//eğer id sayısı 7 ise
                            sayacavci++;//koşul sağlandığı zaman sayacı tek tek arttır


                        sayac++;//bütün sayıları bulmak için toplam sayaç
                    }

                }
            }
            Console.Write(("").PadRight(34, '-') + "\n" + "Alanda Bulunan Koyun Sayısı:\t" + sayackoyun + "\n" + "Alanda Bulunan Kurt Sayısı:\t" + sayackurt + "\n" + "Alanda Bulunan Inek Sayısı:\t" + sayacinek + "\n" + "Alanda Bulunan Tavuk Sayısı:\t" + sayactavuk + "\n" + "Alanda Bulunan Horoz Sayısı:\t" + sayachoroz + "\n" + "Alanda Bulunan Aslan Sayısı:\t" + sayacaslan + "\n" + "Alanda Bulunan Avcı Sayısı:\t" + sayacavci + "\n" + ("").PadRight(34, '-') + "\n");
            //yüklenen sayaçları yazdırdık.
            Console.WriteLine("Toplam Canlı Sayısı: " + sayac);//toplam hayvan sayısını yazdırdık
        }
        public void BaslangicListesi()
        {
            int sayac = 0;//*
            int sayackoyun = 0;//*
            int sayackurt = 0;//*
            int sayacinek = 0;//*
            int sayactavuk = 0;//*
            int sayachoroz = 0;//*
            int sayacaslan = 0;//*
            int sayacavci = 0;//*
            //* sayaclarımızı tanımladık.(yukarı sayaçlarla aynı görevleri)
            for (int i = 0; i < 500; i++)
            {//2 boyutlu dizinin satır boyunca dönecek döngü
                for (int j = 0; j < 500; j++)
                {//2 boyutlu dizinin sütun boyunca dönecek döngü
                    if (AlanOlustur.alan[i, j] != 0)
                    {//Alanolustur sınıfından Alan matrisimizi globalde tanımklı olduğu için alabiliyoruz
                        if (AlanOlustur.alan[i, j] == 1.1 || AlanOlustur.alan[i, j] == 1.2)//eğer 1. sayının erkek veya dişisi(0.1,0.2)
                            sayackoyun++;//koşul sağlandığı zaman sayacı tek tek arttır
                        else if (AlanOlustur.alan[i, j] == 2.1 || AlanOlustur.alan[i, j] == 2.2)//eğer 2. sayının erkek veya dişisi(0.1,0.2)
                            sayackurt++;//koşul sağlandığı zaman sayacı tek tek arttır
                        else if (AlanOlustur.alan[i, j] == 3.1 || AlanOlustur.alan[i, j] == 3.2)//eğer 3. sayının erkek veya dişisi(0.1,0.2)
                            sayacinek++;//koşul sağlandığı zaman sayacı tek tek arttır
                        else if (AlanOlustur.alan[i, j] == 4)//eğer id sayısı 4 ise
                            sayactavuk++;//koşul sağlandığı zaman sayacı tek tek arttır
                        else if (AlanOlustur.alan[i, j] == 5)//eğer id sayısı 5 ise
                            sayachoroz++;//koşul sağlandığı zaman sayacı tek tek arttır
                        else if (AlanOlustur.alan[i, j] == 6.1 || AlanOlustur.alan[i, j] == 6.2)//eğer 6. sayının erkek veya dişisi(0.1,0.2)
                            sayacaslan++;//koşul sağlandığı zaman sayacı tek tek arttır
                        else if (AlanOlustur.alan[i, j] == 7)//eğer id sayısı 7 ise
                            sayacavci++;//koşul sağlandığı zaman sayacı tek tek arttır


                        sayac++;//bütün sayıları bulmak için toplam sayaç
                    }

                }
            }

            //Aldığımız değerleri listelemek için kullandık. 
            //değerleri yanyana yazdırdık.|("").PadRight(22, '-')| bu kod ile de aynı oranda çizgilendirdik(görüntü).
            Console.WriteLine("\t\t\tALANDAKİ HAYVANLAR");
            Console.WriteLine("\t\t      "+ ("").PadRight(22, '-'));
            Console.Write("KOYUN\t");
            Console.Write("KURT\t");
            Console.Write("İNEK\t");
            Console.Write("TAVUK\t");
            Console.Write("HOROZ\t");
            Console.Write("ASLAN\t");
            Console.Write("AVCI\t");
            Console.Write("TOPLAM\t");
            Console.WriteLine();
            Console.Write(("").PadRight(5, '-') + "\t");
            Console.Write(("").PadRight(4, '-') + "\t");
            Console.Write(("").PadRight(4, '-') + "\t");
            Console.Write(("").PadRight(5, '-') + "\t");
            Console.Write(("").PadRight(5, '-') + "\t");
            Console.Write(("").PadRight(5, '-') + "\t");
            Console.Write(("").PadRight(4, '-') + "\t");
            Console.Write(("").PadRight(6, '-') + "\t");
            Console.WriteLine();
            Console.Write(" " + sayackoyun + "\t");
            Console.Write(" " + sayackurt + "\t");
            Console.Write(" " + sayacinek + "\t");
            Console.Write(" " + sayactavuk + "\t");
            Console.Write(" " + sayachoroz + "\t");
            Console.Write(" " + sayacaslan + "\t");
            Console.Write(" " + sayacavci + "\t");
            Console.Write("  " + sayac + "\t");
            Console.WriteLine();
            Console.WriteLine(("").PadRight(62, '-'));
            Console.WriteLine();


        }
    }
}
