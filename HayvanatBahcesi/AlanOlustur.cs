using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    public class AlanOlustur
    {
        //ALAN VE HAYVAN OLUŞTURMA SINIFI
        public static int hareketSayisi = 0;//globalde hareket sayısı değişkeni

        public static double[,] alan = new double[500, 500];//Hayvanat Bahçesi Alanı

        public static Hayvanlar hayvanlar = new Hayvanlar();//Hayvanlar sınıfı nesnesi

        public static Random rasgele = new Random();//rasgele değerler oluşturmak için random kütüphanesi


        public void Olustur()
        {
            //alan ve hayvan oluşturma
            int adet ;
            double ID ;
            //+6 hayvan ve 1 Avcı oluşturma için 7 adet değer dönecektir. hayvanlar sınıfında belirttiğimiz gibi her bir hayvana bir id numarası verdik. bu değerlere göre döngümüz her defasında işlem yapacaktır.

            for (int i = 0; i < 7; i++)
            {
                if (i == 0)
                {//i değişkenizim 0 ise 1 id numaralı hayvanımız işlem görecektir.
                    adet = hayvanlar.Koyun();
                    ID = 1.1;
                }
                else if (i == 1)
                {//i değişkenizim 1 ise 2 id numaralı hayvanımız işlem görecektir.
                    adet = hayvanlar.Kurt();
                    ID = 2.1;
                }
                else if (i == 2)
                {//i değişkenizim 2 ise 3 id numaralı hayvanımız işlem görecektir.
                    adet = hayvanlar.Inek();
                    ID = 3.1;
                }
                else if (i == 3)
                {//i değişkenizim 3 ise 4 id numaralı hayvanımız işlem görecektir.
                    adet = hayvanlar.Tavuk();
                    ID = 4;
                }
                else if (i == 4)
                {//i değişkenizim 4 ise 5 id numaralı hayvanımız işlem görecektir.
                    adet = hayvanlar.Horoz();
                    ID = 5;
                }
                else if (i == 5)
                {//i değişkenizim 5 ise 6 id numaralı hayvanımız işlem görecektir.
                    adet = hayvanlar.Aslan();
                    ID = 6.1;
                }
                else
                {//i değişkenizim 6 ise 7 id numaralı hayvanımız işlem görecektir.
                    adet = hayvanlar.Avcı();
                    ID = 7;
                }
                // burada erkek veya dişi diye ayırmadığımız tavuk horoz ve avcı için tek değerlerle işlem yapacağımız alan mevcut. bu işlemler tek bir koşul ile olduğu için ayırdık
                if (ID == 7)
                {// eğer id 7 ise yani avcı ise
                    int randomsatir = rasgele.Next(1, 500);//rasgele satır belirle
                    int randomsutun = rasgele.Next(1, 500);//rasgele sütun belirle
                    if (alan[randomsatir, randomsutun] == 0)//belirlenen yerde hayvan varmı? yani yoksa(sıfır ise bu yerimiz)
                    {
                        alan[randomsatir, randomsutun] = ID;// avcı diye adlandırılan 7 id numarasını buraya atadık
                    }
                    else
                    {//belirtilen rasgele yer dolu ise 
                        i--;//bu döngüyü tekrar çağırarak avcı için tekrar rasgele yer gelirleyeceğiz.
                    }
                }
                else if (ID == 4)
                {//eğer id 4 ise yani tavuk için bir değer ise
                    for (int j = 0; j < adet; j++)
                    {//hayvanlar sınıfında da belirtilen adet sayısı kadar tavuk ekleyeceğiz alana. döngü adet kadar dönecektir.
                        int randomsatir = rasgele.Next(1, 500);//rasgele satır.
                        int randomsutun = rasgele.Next(1, 500);//rasgele sütun
                        if (alan[randomsatir, randomsutun] == 0)//belirlenen yerde hayvan varmı? yani yoksa(sıfır ise bu yerimiz)
                        {
                            alan[randomsatir, randomsutun] = ID;// tavuk diye adlandırılan hayvan için 4 id numarasını bu yere atadık atadık
                        }
                    }
                }
                else if (ID == 5)
                {//eğer id 5 ise yani horoz için bir değer ise
                    for (int j = 0; j < adet; j++)
                    {//hayvanlar sınıfında da belirtilen adet sayısı kadar horoz ekleyeceğiz alana. döngü adet kadar dönecektir.
                        int randomsatir = rasgele.Next(1, 500);//rasgele satır
                        int randomsutun = rasgele.Next(1, 500);//rasgele sütun
                        if (alan[randomsatir, randomsutun] == 0)//belirlenen yerde hayvan varmı? yani yoksa(sıfır ise bu yerimiz)
                        {
                            alan[randomsatir, randomsutun] = ID;// horoz diye adlandırılan hayvan için 5 id numarasını bu yere atadık atadık
                        }
                    }

                }
                else
                {//şimdi gelen id değerleri 4,5 ve 7 değilse. yani bu alan ciftler için geçerli(1,2,3,6)
                    int yarisi = adet / 2;//şimdi gelen hayvanlar için yarısı erkek yarısı dişi olacağı için gelen adet sayısını 2 ye bölerek erkek ve dişi eklemesi yapacağız

                    for (int j = 0; j < adet; j++)
                    {//önceki hayvanlarda yaptığımız gibi adede kadar hayvan ekleyeceğiz
                        if (ID < 0 || ID > 8)//burada koşul belirttik. yani gelen id değeri 0 ile 8 arasında olmalı
                        {
                            Console.WriteLine("işlem yapılamadı.");
                        }
                        else
                        {//adede göre ekleme yapacağız fakat eş durumunu 
                            if (j < yarisi)//bu koşul ile sağlayacağız. şimdi gelen döngü değerimiz belirtilen yarın adetten büyük olana kadar erkek ekleyecektir. eğer buyuk olursa sonraki her işlemde dişi eklemesi yapacaktır.
                            {
                                int randomsatir = rasgele.Next(1, 500);//rasgele satır
                                int randomsutun = rasgele.Next(1, 500);//rasgele sütun
                                if (alan[randomsatir, randomsutun] == 0)//belirlenen yerde hayvan varmı? yani yoksa(sıfır ise bu yerimiz)
                                {
                                    alan[randomsatir, randomsutun] = ID;// belirtilen rasgele yer boş ise atama işlemimizi yapacağız.
                                }
                                else//rasgele yer dolu ise aynı işlemi tekrarlamak için döngü düşüreceğiz
                                {
                                    j--;//döngü devresi düşürme işlemi
                                }
                            }
                            else//j yarısından fazla olduğu takdirde bu işlemlerle dişi eklemesi yapacağız.
                            {
                                int randomsatir = rasgele.Next(1, 500);//rasgele satır
                                int randomsutun = rasgele.Next(1, 500);//rasgele sütun
                                if (alan[randomsatir, randomsutun] == 0)//belirlenen yerde hayvan varmı? yani yoksa(sıfır ise bu yerimiz)
                                {//şimdi bu alanda 0.2 yani dişileri ekleyeceğiz. bu eklemede toplamda bir problem ile karşılaştık ve çözüm başarıyla gerçekleşti
                                    //sorun: 1.1+0.1=1.200000000002
                                    //toplamda değeri böyle yazdırdı. sorunu ondalık sayılarda sayı sonrası ondalık değerden tek bir basamağı almakla çözdüm. yani gelen değerde 1.2 sayısını alacağım sonuç ne olursa olsun.
                                    double toplam = ID + 0.1;
                                    toplam = Math.Round(toplam, 1);//sayı sontası bir basamak alma durumu.
                                    alan[randomsatir, randomsutun] = toplam;//belirtilen alana bu değeri atadık(0.2 dişi değerler.)
                                }
                                else//rasgele yer dolu ise aynı işlemi tekrarlamak için döngü düşüreceğiz
                                {
                                    j--;//döngü devresi düşürme işlemi
                                }
                            }
                        }
                    }
                }
            }
        }

    }
}
