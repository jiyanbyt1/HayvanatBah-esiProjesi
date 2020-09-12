using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    public class Hareketler
    {
        //HAREKERLERİMİZİN İŞLEME ALINDIĞI SINIFIMIZ.

        public static int hareketSayisi = 0; //Hayvanların toplam hareket sayısını aldığımız globale tanımlı olan değişkenimiz.
        public static Random rasgele = new Random();//rasgele sayı üretmek için random kütüphanesinden alınan rasgele nesnesi.
        public void CtrlHareket(double gelenErkek, double gelenDisi, int hareketi)//her hayvan için hareket yazmak yerine tek bir işlemle değişkenlerden alınan değerlerle her bir hayvana tek kod bloğu ile işlem yapmaktayız. parametrelerden gelen id numaralarını alıyoruz.
        {
            double[,] Sira = new double[500, 500];//işlem yapılan hayvanları tutmak ve o hayvanlar için tekrar işlem yapmamak amacıyla bir alan kpyası oluşturduk.
            int alt = 0;//alt sınırı belirlemek için değişken
            int ust = 0;//üst sınırı belirlemek için değişken
            if (hareketi == 1)
            {//gelen parametredeki hayvan id numarası 1 ise yani koyun ise alt ve üst sınırları belirledik. her hayvan için bu değerler birim hareketlerine göre farklılık gösterdiği için koşullandırdık.
                alt = 2;
                ust = 497;
            }
            else if (hareketi == 2)
            {//gelen parametredeki hayvan id numarası 2 ise yani kurt ise alt ve üst sınırları belirledik. her hayvan için bu değerler birim hareketlerine göre farklılık gösterdiği için koşullandırdık.
                alt = 3;
                ust = 496;
            }
            else if (hareketi == 3)
            {//gelen parametredeki hayvan id numarası 3 ise yani inek ise alt ve üst sınırları belirledik. her hayvan için bu değerler birim hareketlerine göre farklılık gösterdiği için koşullandırdık.
                alt = 2;
                ust = 497;
            }
            else if (hareketi == 4)
            {//gelen parametredeki hayvan id numarası 4 ise yani tavuk ise alt ve üst sınırları belirledik. her hayvan için bu değerler birim hareketlerine göre farklılık gösterdiği için koşullandırdık.
                alt = 1;
                ust = 498;
            }
            else if (hareketi == 5)
            {//gelen parametredeki hayvan id numarası 5 ise yani horoz ise alt ve üst sınırları belirledik. her hayvan için bu değerler birim hareketlerine göre farklılık gösterdiği için koşullandırdık.
                alt = 1;
                ust = 498;
            }
            else if (hareketi == 6)
            {//gelen parametredeki hayvan id numarası 6 ise yani aslan ise alt ve üst sınırları belirledik. her hayvan için bu değerler birim hareketlerine göre farklılık gösterdiği için koşullandırdık.
                alt = 4;
                ust = 495;
            }
            else if (hareketi == 7)
            {//gelen parametredeki hayvan id numarası 7 ise yani avcı ise alt ve üst sınırları belirledik. her hayvan için bu değerler birim hareketlerine göre farklılık gösterdiği için koşullandırdık.
                alt = 1;
                ust = 498;
            }
            else
            {

            }


            Hareket hareket = new Hareket();
            for (int i = 0; i < 500; i++)
            {//2 boyutlu dizi için satır döngüsü
                for (int j = 0; j < 500; j++)
                {//2 boyutlu dizi için sütun döngüsü
                    if (AlanOlustur.alan[i, j] != 0)
                    {//eğer sürekli taranacak olan döngülerde tek tek durulan değerler 0 değilse(yani herhangi bir hayvan varsa)
                        if (AlanOlustur.alan[i, j] == gelenErkek || AlanOlustur.alan[i, j] == gelenDisi)
                        {//bu gelen değer parametreden alınan değerle eşitse(yani bulunan hayvan istenen hayvana eşit ise) hareket işlemini sağlayacağız.
                            int yon = rasgele.Next(1, 5);//hangi yöne gideceğini random değerle almaktayız. açıklama satırını sadece 1 yön için yapacağım
                            if (yon == 1)
                            {//yön bir ise
                                if (Sira[i, j] == 0)
                                {//ikinci kopya alanda da o değer aynı konumda yoksa (yani işlem yapılmayan bir hayvan ise)
                                    if (i < ust && i > alt && j < ust && j > alt)//alt ve üst sınırlar sağlanıyorsa(yani alan dışına çıkılmayacaksa)
                                    {

                                        if (hareketi == 1)//hayvana özel işlem yapılacağı için gelen hayvan hangisi ise koşulu sağlayan kısımda yani hayvan hangi alanda aitse o alanda işlem yapılacaktır.
                                        {//eğer 1 ise gelen değer
                                            if (AlanOlustur.alan[i, j + hareket.Koyun()] == 0 && Sira[i, j + hareket.Koyun()]==0)//hayvanın hareket edeceği yeri kontrol ediyoruz. eğer boş ise
                                            {
                                                AlanOlustur.alan[i, j + hareket.Koyun()] = AlanOlustur.alan[i, j];//hayvanı o konuma doğru hareket ettirdik.(yani bulunan hayvan id değerini yeni konuma yazdık.)
                                                Sira[i, j + hareket.Koyun()] = AlanOlustur.alan[i, j];//işlem yapıldığı için yeni konuma fakat kopya alana hayvanı kaydediyoruz. her başlangıçta bu alan kontrol edilir. hayvan varsa işlem gördüğünü belli eder ve işleme tekrar tabi olmaz
                                                AlanOlustur.alan[i, j] = 0;//hayvanın id numarasını eski yerinden siliyoruz
                                                hareketSayisi += hareket.Koyun();//hareket sayısını hareker nesnesinden alarak arttırıyoruz
                                            }
                                            else
                                            {//Koşullar gerekli düzeyde sağlanmadıysa döngü tekrarı
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 2)
                                        {//eğer 2 ise gelen değer
                                            if (AlanOlustur.alan[i, j + hareket.Kurt()] == 0 && Sira[i, j + hareket.Kurt()] == 0)//hayvanın hareket edeceği yeri kontrol ediyoruz. eğer boş ise
                                            {
                                                AlanOlustur.alan[i, j + hareket.Kurt()] = AlanOlustur.alan[i, j];//hayvanı o konuma doğru hareket ettirdik.(yani bulunan hayvan id değerini yeni konuma yazdık.)
                                                Sira[i, j + hareket.Kurt()] = AlanOlustur.alan[i, j];//işlem yapıldığı için yeni konuma fakat kopya alana hayvanı kaydediyoruz. her başlangıçta bu alan kontrol edilir. hayvan varsa işlem gördüğünü belli eder ve işleme tekrar tabi olmaz
                                                AlanOlustur.alan[i, j] = 0;//hayvanın id numarasını eski yerinden siliyoruz
                                                hareketSayisi += hareket.Kurt();//hareket sayısını hareker nesnesinden alarak arttırıyoruz
                                            }
                                            else
                                            {//Koşullar gerekli düzeyde sağlanmadıysa döngü tekrarı
                                                j--;
                                            }

                                        }
                                        else if (hareketi == 3)
                                        {//eğer 3 ise gelen değer
                                            if (AlanOlustur.alan[i, j + hareket.Inek()] == 0 && Sira[i, j + hareket.Inek()] == 0)//hayvanın hareket edeceği yeri kontrol ediyoruz. eğer boş ise
                                            {
                                                AlanOlustur.alan[i, j + hareket.Inek()] = AlanOlustur.alan[i, j];//hayvanı o konuma doğru hareket ettirdik.(yani bulunan hayvan id değerini yeni konuma yazdık.)
                                                Sira[i, j + hareket.Inek()] = AlanOlustur.alan[i, j];//işlem yapıldığı için yeni konuma fakat kopya alana hayvanı kaydediyoruz. her başlangıçta bu alan kontrol edilir. hayvan varsa işlem gördüğünü belli eder ve işleme tekrar tabi olmaz
                                                AlanOlustur.alan[i, j] = 0;//hayvanın id numarasını eski yerinden siliyoruz
                                                hareketSayisi += hareket.Inek();//hareket sayısını hareker nesnesinden alarak arttırıyoruz
                                            }
                                            else
                                            {//Koşullar gerekli düzeyde sağlanmadıysa döngü tekrarı
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 4)
                                        {//eğer 4 ise gelen değer
                                            if (AlanOlustur.alan[i, j + hareket.Tavuk()] == 0 && Sira[i, j + hareket.Tavuk()] == 0)//hayvanın hareket edeceği yeri kontrol ediyoruz. eğer boş ise
                                            {
                                                AlanOlustur.alan[i, j + hareket.Tavuk()] = AlanOlustur.alan[i, j];//hayvanı o konuma doğru hareket ettirdik.(yani bulunan hayvan id değerini yeni konuma yazdık.)
                                                Sira[i, j + hareket.Tavuk()] = AlanOlustur.alan[i, j];//işlem yapıldığı için yeni konuma fakat kopya alana hayvanı kaydediyoruz. her başlangıçta bu alan kontrol edilir. hayvan varsa işlem gördüğünü belli eder ve işleme tekrar tabi olmaz
                                                AlanOlustur.alan[i, j] = 0;//hayvanın id numarasını eski yerinden siliyoruz
                                                hareketSayisi += hareket.Tavuk();//hareket sayısını hareker nesnesinden alarak arttırıyoruz
                                            }
                                            else
                                            {//Koşullar gerekli düzeyde sağlanmadıysa döngü tekrarı
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 5)
                                        {//eğer 5 ise gelen değer
                                            if (AlanOlustur.alan[i, j + hareket.Horoz()] == 0 && Sira[i, j + hareket.Horoz()] == 0)//hayvanın hareket edeceği yeri kontrol ediyoruz. eğer boş ise
                                            {
                                                AlanOlustur.alan[i, j + hareket.Horoz()] = AlanOlustur.alan[i, j];//hayvanı o konuma doğru hareket ettirdik.(yani bulunan hayvan id değerini yeni konuma yazdık.)
                                                Sira[i, j + hareket.Horoz()] = AlanOlustur.alan[i, j];//işlem yapıldığı için yeni konuma fakat kopya alana hayvanı kaydediyoruz. her başlangıçta bu alan kontrol edilir. hayvan varsa işlem gördüğünü belli eder ve işleme tekrar tabi olmaz
                                                AlanOlustur.alan[i, j] = 0;//hayvanın id numarasını eski yerinden siliyoruz
                                                hareketSayisi += hareket.Horoz();//hareket sayısını hareker nesnesinden alarak arttırıyoruz
                                            }
                                            else
                                            {//Koşullar gerekli düzeyde sağlanmadıysa döngü tekrarı
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 6)
                                        {//eğer 6 ise gelen değer
                                            if (AlanOlustur.alan[i, j + hareket.Aslan()] == 0 && Sira[i, j + hareket.Aslan()] == 0)//hayvanın hareket edeceği yeri kontrol ediyoruz. eğer boş ise
                                            {
                                                AlanOlustur.alan[i, j + hareket.Aslan()] = AlanOlustur.alan[i, j];//hayvanı o konuma doğru hareket ettirdik.(yani bulunan hayvan id değerini yeni konuma yazdık.)
                                                Sira[i, j + hareket.Aslan()] = AlanOlustur.alan[i, j];//işlem yapıldığı için yeni konuma fakat kopya alana hayvanı kaydediyoruz. her başlangıçta bu alan kontrol edilir. hayvan varsa işlem gördüğünü belli eder ve işleme tekrar tabi olmaz
                                                AlanOlustur.alan[i, j] = 0;//hayvanın id numarasını eski yerinden siliyoruz
                                                hareketSayisi += hareket.Aslan();//hareket sayısını hareker nesnesinden alarak arttırıyoruz
                                            }
                                            else
                                            {//Koşullar gerekli düzeyde sağlanmadıysa döngü tekrarı
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 7)
                                        {//eğer 7 ise gelen değer
                                            if (AlanOlustur.alan[i, j + hareket.Avcı()] == 0 && Sira[i, j + hareket.Avcı()] == 0)//hayvanın hareket edeceği yeri kontrol ediyoruz. eğer boş ise
                                            {
                                                AlanOlustur.alan[i, j + hareket.Avcı()] = AlanOlustur.alan[i, j];//hayvanı o konuma doğru hareket ettirdik.(yani bulunan hayvan id değerini yeni konuma yazdık.)
                                                Sira[i, j + hareket.Avcı()] = AlanOlustur.alan[i, j];//işlem yapıldığı için yeni konuma fakat kopya alana hayvanı kaydediyoruz. her başlangıçta bu alan kontrol edilir. hayvan varsa işlem gördüğünü belli eder ve işleme tekrar tabi olmaz
                                                AlanOlustur.alan[i, j] = 0;//hayvanın id numarasını eski yerinden siliyoruz
                                                hareketSayisi += hareket.Avcı();//hareket sayısını hareker nesnesinden alarak arttırıyoruz
                                            }
                                            else
                                            {//Koşullar gerekli düzeyde sağlanmadıysa döngü tekrarı
                                                j--;
                                            }
                                        }
                                        else
                                        {//Koşullar gerekli düzeyde sağlanmadıysa döngü tekrarı
                                            j--;
                                        }

                                    }
                                }
                                
                            }//eğer 1 ise sütunda ilerleme yapacaktır(("SADECE BU YÖN İÇİN AÇIKLAMA YAPACAĞIM. İŞLEMLER GENEL OLARAK AYNI. FARKALRI İSE GERİ YAPILACAĞI ZAMAN ÇIKARMA İŞLEMİ UYGULANACAĞI VE SATIR, SÜTUN FARKLILIĞIDIR."))
                            else if (yon == 2)
                            {
                                if (Sira[i, j] == 0)
                                {
                                    if (i < ust && i > alt && j < ust && j > alt)
                                    {
                                        if (hareketi == 1)
                                        {
                                            if (AlanOlustur.alan[i, j - hareket.Koyun()] == 0 && Sira[i, j - hareket.Koyun()]==0)
                                            {

                                                AlanOlustur.alan[i, j - hareket.Koyun()] = AlanOlustur.alan[i, j];
                                                Sira[i, j - hareket.Koyun()] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Koyun();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 2)
                                        {
                                            if (AlanOlustur.alan[i, j - hareket.Kurt()] == 0 && Sira[i, j - hareket.Kurt()] == 0)
                                            {
                                                AlanOlustur.alan[i, j - hareket.Kurt()] = AlanOlustur.alan[i, j];
                                                Sira[i, j - hareket.Kurt()] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Kurt();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 3)
                                        {
                                            if (AlanOlustur.alan[i, j - hareket.Inek()] == 0 && Sira[i, j - hareket.Inek()] == 0)
                                            {
                                                AlanOlustur.alan[i, j - hareket.Inek()] = AlanOlustur.alan[i, j];
                                                Sira[i, j - hareket.Inek()] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Inek();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 4)
                                        {
                                            if (AlanOlustur.alan[i, j - hareket.Tavuk()] == 0 && Sira[i, j - hareket.Tavuk()] == 0)
                                            {
                                                AlanOlustur.alan[i, j - hareket.Tavuk()] = AlanOlustur.alan[i, j];
                                                Sira[i, j - hareket.Tavuk()] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Tavuk();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 5)
                                        {
                                            if (AlanOlustur.alan[i, j - hareket.Horoz()] == 0 && Sira[i, j - hareket.Horoz()] == 0)
                                            {
                                                AlanOlustur.alan[i, j - hareket.Horoz()] = AlanOlustur.alan[i, j];
                                                Sira[i, j - hareket.Horoz()] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Horoz();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 6)
                                        {
                                            if (AlanOlustur.alan[i, j - hareket.Aslan()] == 0 && Sira[i, j - hareket.Aslan()] == 0)
                                            {
                                                AlanOlustur.alan[i, j - hareket.Aslan()] = AlanOlustur.alan[i, j];
                                                Sira[i, j - hareket.Aslan()] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Aslan();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 7)
                                        {
                                            if (AlanOlustur.alan[i, j - hareket.Avcı()] == 0 && Sira[i, j - hareket.Avcı()] == 0)
                                            {
                                                AlanOlustur.alan[i, j - hareket.Avcı()] = AlanOlustur.alan[i, j];
                                                Sira[i, j - hareket.Avcı()] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Avcı();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else
                                        {
                                            j--;
                                        }
                                    }
                                }

                            }//eğer 2 ise sütunda geriye doğru hareket yapacaktır
                            else if (yon == 3)
                            {
                                if (Sira[i, j] == 0)
                                {
                                    if (i < ust && i > alt && j < ust && j > alt)
                                    {
                                        if (hareketi == 1)
                                        {
                                            if (AlanOlustur.alan[i + hareket.Koyun(), j] == 0)
                                            {
                                                AlanOlustur.alan[i + hareket.Koyun(), j] = AlanOlustur.alan[i, j];
                                                Sira[i + hareket.Koyun(), j] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Koyun();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 2)
                                        {
                                            if (AlanOlustur.alan[i + hareket.Kurt(), j] == 0)
                                            {
                                                AlanOlustur.alan[i + hareket.Kurt(), j] = AlanOlustur.alan[i, j];
                                                Sira[i + hareket.Kurt(), j] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Kurt();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 3)
                                        {
                                            if (AlanOlustur.alan[i + hareket.Inek(), j] == 0)
                                            {
                                                AlanOlustur.alan[i + hareket.Inek(), j] = AlanOlustur.alan[i, j];
                                                Sira[i + hareket.Inek(), j] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Inek();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 4)
                                        {
                                            if (AlanOlustur.alan[i + hareket.Tavuk(), j] == 0)
                                            {
                                                AlanOlustur.alan[i + hareket.Tavuk(), j] = AlanOlustur.alan[i, j];
                                                Sira[i + hareket.Tavuk(), j] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Tavuk();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 5)
                                        {
                                            if (AlanOlustur.alan[i + hareket.Horoz(), j] == 0)
                                            {
                                                AlanOlustur.alan[i + hareket.Horoz(), j] = AlanOlustur.alan[i, j];
                                                Sira[i + hareket.Horoz(), j] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Horoz();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 6)
                                        {
                                            if (AlanOlustur.alan[i + hareket.Aslan(), j] == 0)
                                            {
                                                AlanOlustur.alan[i + hareket.Aslan(), j] = AlanOlustur.alan[i, j];
                                                Sira[i + hareket.Aslan(), j] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Aslan();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 7)
                                        {
                                            if (AlanOlustur.alan[i + hareket.Avcı(), j] == 0)
                                            {
                                                AlanOlustur.alan[i + hareket.Avcı(), j] = AlanOlustur.alan[i, j];
                                                Sira[i + hareket.Avcı(), j] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Avcı();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else
                                        {
                                            j--;
                                        }
                                    }
                                }
                            }//eğer 3 ise satırda ilerleme yapacaktır
                            else
                            {
                                if (Sira[i, j] == 0)
                                {
                                    if (i < ust && i > alt && j < ust && j > alt)
                                    {
                                        if (hareketi == 1)
                                        {
                                            if (AlanOlustur.alan[i - hareket.Koyun(), j] == 0 && Sira[i - hareket.Koyun(), j]==0)
                                            {
                                                AlanOlustur.alan[i - hareket.Koyun(), j] = AlanOlustur.alan[i, j];
                                                Sira[i - hareket.Koyun(), j] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Koyun();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 2)
                                        {
                                            if (AlanOlustur.alan[i - hareket.Kurt(), j] == 0 && Sira[i - hareket.Kurt(), j] == 0)
                                            {
                                                AlanOlustur.alan[i - hareket.Kurt(), j] = AlanOlustur.alan[i, j];
                                                Sira[i - hareket.Kurt(), j] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Kurt();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 3)
                                        {
                                            if (AlanOlustur.alan[i - hareket.Inek(), j] == 0 && Sira[i - hareket.Inek(), j] == 0)
                                            {
                                                AlanOlustur.alan[i - hareket.Inek(), j] = AlanOlustur.alan[i, j];
                                                Sira[i - hareket.Inek(), j] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Inek();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 4)
                                        {
                                            if (AlanOlustur.alan[i - hareket.Tavuk(), j] == 0 && Sira[i - hareket.Tavuk(), j] == 0)
                                            {
                                                AlanOlustur.alan[i - hareket.Tavuk(), j] = AlanOlustur.alan[i, j];
                                                Sira[i - hareket.Tavuk(), j] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Tavuk();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 5)
                                        {
                                            if (AlanOlustur.alan[i - hareket.Horoz(), j] == 0 && Sira[i - hareket.Horoz(), j] == 0)
                                            {
                                                AlanOlustur.alan[i - hareket.Horoz(), j] = AlanOlustur.alan[i, j];
                                                Sira[i - hareket.Horoz(), j] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Horoz();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 6)
                                        {
                                            if (AlanOlustur.alan[i - hareket.Aslan(), j] == 0 && Sira[i - hareket.Aslan(), j] == 0)
                                            {
                                                AlanOlustur.alan[i - hareket.Aslan(), j] = AlanOlustur.alan[i, j];
                                                Sira[i - hareket.Aslan(), j] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Aslan();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else if (hareketi == 7)
                                        {
                                            if (AlanOlustur.alan[i - hareket.Avcı(), j] == 0 && Sira[i - hareket.Avcı(), j] == 0)
                                            {
                                                AlanOlustur.alan[i - hareket.Avcı(), j] = AlanOlustur.alan[i, j];
                                                Sira[i - hareket.Avcı(), j] = AlanOlustur.alan[i, j];
                                                AlanOlustur.alan[i, j] = 0;
                                                hareketSayisi += hareket.Avcı();
                                            }
                                            else
                                            {
                                                j--;
                                            }
                                        }
                                        else
                                        {
                                            j--;
                                        }
                                    }
                                }

                            }//eğer 4 ise satırda geriye doğru hareket yapacaktır
                        }
                    }
                }
            }
        }
    }
}
