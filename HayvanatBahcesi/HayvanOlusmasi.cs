using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    public class HayvanOlusmasi
    {//HAYVAN OLUŞTURULACAK ALAN SINIFI
        public static Random rasgele = new Random();//rasgele değerler oluşturmak için random kütüphanesi
        public static Hayvanlar hayvanlar = new Hayvanlar();//Hayvanlar sınıfı nesnesi

        public void Olusma(double gelenilk, double sorgulatan)
        {//KOŞUL: iki adet aynı tür farklı cins hayvan 3 birim birbirlerine yaklaştıkları zaman yeni bir tane aynı tür rasgele cins ile meydana gelmesi
            //bu işlemleri her bir hayvan için her bir yön kontrolü tek tek yazmak yerine dışarıdan tek tek değerler alarak işlemleri yaptırıyoruz. parametreden gelen hayvan ve eşi.
            for (int i = 0; i < 500; i++)
            {//2 boyutlu dizinin satır boyunca dönecek döngü
                for (int j = 0; j < 500; j++)
                {//2 boyutlu dizinin sütun boyunca dönecek döngü
                    if (AlanOlustur.alan[i, j] != 0)
                    {//eğer gelen her bir matris indisi sıfırdan farklıysa(yani hayvan sorgulaması yapıyoruz her bir değer için)
                        if (AlanOlustur.alan[i, j] != 7)
                        {//eğer gelen her bir matris indisi 7 id değerinden farklıysa(yani avcının bu koşula girmemesi için şartlandırma sunuyoruz)
                            if (AlanOlustur.alan[i, j] == gelenilk)
                            {//bizim bakacağımız hayvanı bütün alanda aratıyoruz. eğer eşleşme varsa 
                                //sağ,sol,aşağı ve yukarı olarak yönlere ayıracağız ve işlemleri ona göre yapacağız
                                for (int x = j + 1; x < j + 3; x++)
                                {//bu for döngüsü bulunan hayvandan sonraki 3 değere bakıyor
                                    if (x < 500)
                                    {//sınır değeri sağlandığı sürece
                                        if (AlanOlustur.alan[i, x] == sorgulatan)
                                        {//her bir birim gittiği yere bizim hayvanımızın eşini sorgulatıyoruz. eğer varsa,
                                            //rasgele cins aynı tür bir hayvan rasgele konuma oluşacaktır.

                                            int Satir = rasgele.Next(1, 500);//rasgele satır
                                            int sutun = rasgele.Next(1, 500);//rasgele sütun
                                            if (AlanOlustur.alan[Satir, sutun] == 0)//yeni verilen rasgele konumda hayvan yoksa
                                            {
                                                int cinsiyet = rasgele.Next(1, 3);//cinsiyet için 2 rasgele değer
                                                if (cinsiyet == 1)//eğer 1 ise
                                                {
                                                    AlanOlustur.alan[Satir, sutun] = gelenilk;//yeni oluşan konuma erkek hayvan
                                                    hayvanlar.Cinsler(gelenilk);//bu hayvanın cinsini yazdırmak için hayvanlar nesnesi ile hayvan cinsleri bulunan sınıfı çağırıyoruz.
                                                    Console.WriteLine(Hayvanlar.Cins + " Meydana Geldi");//sonuca göre yazdırıyoruz

                                                }
                                                else
                                                {//eğer 2 ise 
                                                    AlanOlustur.alan[Satir, sutun] = sorgulatan;//yeni oluşan konuma dişi hayvan
                                                    hayvanlar.Cinsler(sorgulatan);//bu hayvanın cinsini yazdırmak için hayvanlar nesnesi ile hayvan cinsleri bulunan sınıfı çağırıyoruz.
                                                    Console.WriteLine(Hayvanlar.Cins + " Meydana Geldi");//sonuca göre yazdırıyoruz
                                                }
                                            }
                                            else
                                            {//yeni oluşan rasgele konum dolu ise tekrar işlemleri başa almak için döngü sayısını 1 azaltıyoruz.
                                                j--;
                                            }

                                        }
                                    }
                                }
                                for (int x = j - 1; x > j - 3; x--)
                                {//bu for döngüsü bulunan hayvandan önceki 3 değere bakıyor
                                    if (x > 0)
                                    {//sınır değeri sağlandığı sürece
                                        if (AlanOlustur.alan[i, x] == sorgulatan)
                                        {//her bir birim gittiği yere bizim hayvanımızın eşini sorgulatıyoruz. eğer varsa,
                                            //rasgele cins aynı tür bir hayvan rasgele konuma oluşacaktır.


                                            int Satir = rasgele.Next(1, 500);//rasgele satır
                                            int sutun = rasgele.Next(1, 500);//rasgele sütun
                                            if (AlanOlustur.alan[Satir, sutun] == 0)//yeni verilen rasgele konumda hayvan yoksa
                                            {
                                                int cinsiyet = rasgele.Next(1, 3);//cinsiyet için 2 rasgele değer
                                                if (cinsiyet == 1)//eğer 1 ise
                                                {
                                                    AlanOlustur.alan[Satir, sutun] = gelenilk;//yeni oluşan konuma erkek hayvan
                                                    hayvanlar.Cinsler(gelenilk);//bu hayvanın cinsini yazdırmak için hayvanlar nesnesi ile hayvan cinsleri bulunan sınıfı çağırıyoruz.
                                                    Console.WriteLine(Hayvanlar.Cins + " Meydana Geldi");//sonuca göre yazdırıyoruz
                                                }
                                                else
                                                {//eğer 2 ise
                                                    AlanOlustur.alan[Satir, sutun] = sorgulatan;//yeni oluşan konuma dişi hayvan
                                                    hayvanlar.Cinsler(sorgulatan);//bu hayvanın cinsini yazdırmak için hayvanlar nesnesi ile hayvan cinsleri bulunan sınıfı çağırıyoruz.
                                                    Console.WriteLine(Hayvanlar.Cins + " Meydana Geldi");//sonuca göre yazdırıyoruz
                                                }
                                            }
                                            else
                                            {//yeni oluşan rasgele konum dolu ise tekrar işlemleri başa almak için döngü sayısını 1 azaltıyoruz.
                                                j--;
                                            }

                                        }
                                    }
                                }
                                for (int x = i + 1; x < i + 3; x++)
                                {//bu for döngüsü bulunan aşağısında kalan yani sütuna bakıyor  3 değere bakıyor
                                    if (x < 500)
                                    {//sınır değeri sağlandığı sürece
                                        if (AlanOlustur.alan[x, j] == sorgulatan)
                                        {//her bir birim gittiği yere bizim hayvanımızın eşini sorgulatıyoruz. eğer varsa,
                                            //rasgele cins aynı tür bir hayvan rasgele konuma oluşacaktır.

                                            int Satir = rasgele.Next(1, 500);//rasgele satır
                                            int sutun = rasgele.Next(1, 500);//rasgele sütun
                                            if (AlanOlustur.alan[Satir, sutun] == 0)//yeni verilen rasgele konumda hayvan yoksa
                                            {
                                                int cinsiyet = rasgele.Next(1, 3);//cinsiyet için 2 rasgele değer
                                                if (cinsiyet == 1)//eğer 1 ise
                                                {
                                                    AlanOlustur.alan[Satir, sutun] = gelenilk;//yeni oluşan konuma erkek hayvan
                                                    hayvanlar.Cinsler(gelenilk);//bu hayvanın cinsini yazdırmak için hayvanlar nesnesi ile hayvan cinsleri bulunan sınıfı çağırıyoruz.
                                                    Console.WriteLine(Hayvanlar.Cins + " Meydana Geldi");//sonuca göre yazdırıyoruz
                                                }
                                                else
                                                {//eğer 2 ise
                                                    AlanOlustur.alan[Satir, sutun] = sorgulatan;//yeni oluşan konuma dişi hayvan
                                                    hayvanlar.Cinsler(sorgulatan);//bu hayvanın cinsini yazdırmak için hayvanlar nesnesi ile hayvan cinsleri bulunan sınıfı çağırıyoruz.
                                                    Console.WriteLine(Hayvanlar.Cins + " Meydana Geldi");//sonuca göre yazdırıyoruz
                                                }
                                            }
                                            else
                                            {//yeni oluşan rasgele konum dolu ise tekrar işlemleri başa almak için döngü sayısını 1 azaltıyoruz.
                                                j--;
                                            }

                                        }
                                    }
                                }
                                for (int x = i - 1; x > i - 3; x--)
                                {//bu for döngüsü bulunan yukarısında kalan yani sütuna bakıyor  3 değere bakıyor
                                    if (x > 0)
                                    {//sınır değeri sağlandığı sürece
                                        if (AlanOlustur.alan[x, j] == sorgulatan)
                                        {//her bir birim gittiği yere bizim hayvanımızın eşini sorgulatıyoruz. eğer varsa,
                                            //rasgele cins aynı tür bir hayvan rasgele konuma oluşacaktır.

                                            int Satir = rasgele.Next(1, 500);//rasgele satır
                                            int sutun = rasgele.Next(1, 500);//rasgele sütun
                                            if (AlanOlustur.alan[Satir, sutun] == 0)//yeni verilen rasgele konumda hayvan yoksa
                                            {
                                                int cinsiyet = rasgele.Next(1, 3);//cinsiyet için 2 rasgele değer
                                                if (cinsiyet == 1)//eğer 1 ise
                                                {
                                                    AlanOlustur.alan[Satir, sutun] = gelenilk;//yeni oluşan konuma erkek hayvan
                                                    hayvanlar.Cinsler(gelenilk);//bu hayvanın cinsini yazdırmak için hayvanlar nesnesi ile hayvan cinsleri bulunan sınıfı çağırıyoruz.
                                                    Console.WriteLine(Hayvanlar.Cins + " Meydana Geldi");//sonuca göre yazdırıyoruz
                                                }
                                                else
                                                {//eğer 2 ise
                                                    AlanOlustur.alan[Satir, sutun] = sorgulatan;//yeni oluşan konuma dişi hayvan
                                                    hayvanlar.Cinsler(sorgulatan);//bu hayvanın cinsini yazdırmak için hayvanlar nesnesi ile hayvan cinsleri bulunan sınıfı çağırıyoruz.
                                                    Console.WriteLine(Hayvanlar.Cins + " Meydana Geldi");//sonuca göre yazdırıyoruz
                                                }
                                            }
                                            else
                                            {//yeni oluşan rasgele konum dolu ise tekrar işlemleri başa almak için döngü sayısını 1 azaltıyoruz.
                                                j--;
                                            }

                                        }
                                    }
                                }

                            }
                        }
                    }
                }
            }

        }
    }
}