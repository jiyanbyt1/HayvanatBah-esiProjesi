using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    //GENEL NOT;
    //3 Adet koşulumuz var. Avcı, Kurt ve Aslan için avlanma koşullarımızı tanımladık ve gerekli koşullarda sağlandımı 
    //bu işlemleri çalışmaktadır. Bu işlemler dışında belirtmem gereken bir konuda, yönler olacaktır.
    //etrafındaki dediğimize göre aşağı, yukarı, sağa ve sola yönlerimiz vardır.
    //ben satır arttırma, satır azaltma , sütun arttırma ve sutun azaltma gibi matris elemanlarına göre etrafını almaktayım


    public class Avlanma
    {//AVLANMA İŞLEMLERİ SINIFI
        public Hayvanlar hayvanlar = new Hayvanlar();//Hayvanlar sınıfı nesnesi
        public void Avlan()
        {
            for (int i = 0; i < 500; i++)
            {//2 boyutlu dizinin satır boyunca dönecek döngü
                for (int j = 0; j < 500; j++)
                {//2 boyutlu dizinin sütun boyunca dönecek döngü
                    if (AlanOlustur.alan[i, j] != 0)
                    {//eğer gelen her bir matris indisi sıfırdan farklıysa(yani hayvan sorgulaması yapıyoruz her bir değer için)
                        if (AlanOlustur.alan[i, j] == 7)
                        {//AVCI İÇİN İŞLEMLER  <Avcı Koşulu: etrafında 8 birim yakınlıktaki herhangi bir hayvanı vurabilir.>

                        //************avcının ilerisinde(sağ tarafında)
                            for (int x = j + 1; x < j + 8; x++)
                            {//Avcı 8 birime kadar olan hayvanları avlama koşulu için 8 defa sorgulama yapacağımız döngü
                                if (x < 500)
                                {//x değer 500 yani sınır değerden küçük oldukça
                                    if (AlanOlustur.alan[i, x] != 0)//gelen yeni değer 0 değilse. yani sırayla ilerisine doğru sorgulama yapıyoruz. hayvan varsa koşulu sunuyoruz.
                                    {

                                        hayvanlar.Cinsler(AlanOlustur.alan[i, x]);//cinsini bulmak için hayvanlar nesnesine başvuruyoruz
                                        Console.WriteLine("Avcı, bir " + Hayvanlar.Cins + "  avladı");//geri dönüş değişkenle sağlanıyor. yani Hayvanlar.cins global değişkeni
                                        AlanOlustur.alan[i, x] = 0;// bulduğu taktirde buraya kadar gelen işlemler sonucunda her koşul sağlanmış olmaktadır. bu durumda o konumadi hayvanı yani değeri 0 yapmaktayız. avcımız hayvan avlamıştır.
                                    }
                                }

                            }
                            //***********Avcının Gerisinde(sol taraf)
                            for (int x = j - 1; x > j - 8; x--)
                            {//Avcı 8 birime kadar olan hayvanları avlama koşulu için 8 defa sorgulama yapacağımız döngü
                                if (x > 0)
                                {//x değer 0 yani sınır değerden büyük oldukça
                                    if (AlanOlustur.alan[i, x] != 0)//hayvan varsa işlem yapılacak
                                    {
                                        hayvanlar.Cinsler(AlanOlustur.alan[i, x]);//cinsini bulmak için hayvanlar nesnesine başvuruyoruz
                                        Console.WriteLine("Avcı, bir " + Hayvanlar.Cins + "  avladı");//geri dönüş değişkenle sağlanıyor. yani Hayvanlar.cins global değişkeni
                                        AlanOlustur.alan[i, x] = 0;// bulduğu taktirde buraya kadar gelen işlemler sonucunda her koşul sağlanmış olmaktadır. bu durumda o konumadi hayvanı yani değeri 0 yapmaktayız. avcımız hayvan avlamıştır.
                                    }
                                }
                            }
                            //***********varsa avcının yukarısında
                            for (int x = i + 1; x < i + 8; x++)
                            {//Avcı 8 birime kadar olan hayvanları avlama koşulu için 8 defa sorgulama yapacağımız döngü
                                if (x < 500)
                                {//x değer 500 yani sınır değerden küçük oldukça
                                    if (AlanOlustur.alan[x, j] != 0)//hayvan varsa işlem yapılacak
                                    {
                                        hayvanlar.Cinsler(AlanOlustur.alan[x, j]);//cinsini bulmak için hayvanlar nesnesine başvuruyoruz
                                        Console.WriteLine("Avcı, bir " + Hayvanlar.Cins + "  avladı");//geri dönüş değişkenle sağlanıyor. yani Hayvanlar.cins global değişkeni
                                        AlanOlustur.alan[x, j] = 0;// bulduğu taktirde buraya kadar gelen işlemler sonucunda her koşul sağlanmış olmaktadır. bu durumda o konumadi hayvanı yani değeri 0 yapmaktayız. avcımız hayvan a
                                    }
                                }
                            }
                            //************varsa avcının aşağısında 
                            for (int x = i - 1; x > i - 8; x--)
                            {//Avcı 8 birime kadar olan hayvanları avlama koşulu için 8 defa sorgulama yapacağımız döngü
                                if (x > 0)
                                {//x değer 0 yani sınır değerden büyük oldukça
                                    if (AlanOlustur.alan[x, j] != 0)//hayvan varsa işlem yapılacak
                                    {
                                        hayvanlar.Cinsler(AlanOlustur.alan[x, j]);//cinsini bulmak için hayvanlar nesnesine başvuruyoruz
                                        Console.WriteLine("Avcı, bir " + Hayvanlar.Cins + "  avladı");//geri dönüş değişkenle sağlanıyor. yani Hayvanlar.cins global değişkeni
                                        AlanOlustur.alan[x, j] = 0;// bulduğu taktirde buraya kadar gelen işlemler sonucunda her koşul sağlanmış olmaktadır. bu durumda o konumadi hayvanı yani değeri 0 yapmaktayız. avcımız hayvan a
                                    }
                                }
                            }
                        }
                        else if (AlanOlustur.alan[i, j] == 2.1 || AlanOlustur.alan[i, j] == 2.2)
                        {//KURT İÇİN İŞLEMLER  <kURT Koşulu: etrafında 4 birim yakınlıktaki Koyun,horoz ve tavuk varsa avlar>

                            //+++++++++++++kurdun ilerisindeki hayvanlar
                            for (int x = j + 1; x < j + 4; x++)
                            {//Kurt 4 birime kadar olan koyun,horoz ve tavuk avlama koşulu için 4 defa sorgulama yapacağımız döngü
                                if (x < 500)
                                {//sınırlar içinde
                                    if (AlanOlustur.alan[i, x] == 1.1 || AlanOlustur.alan[i, x] == 1.2 || AlanOlustur.alan[i, x] == 4 || AlanOlustur.alan[i, x] == 5)//Sorgulanacak değerler 1 için koyun, 4 için tavuk ve 5 için horoz varsa
                                    {//herhangi biri varsa
                                        hayvanlar.Cinsler(AlanOlustur.alan[i,x]);//hayvanlar nesnesinden cinsi al
                                        Console.WriteLine("Kurt, bir " + Hayvanlar.Cins + "  avladı");//Ekrana yazdır
                                        AlanOlustur.alan[i, x] = 0;//avlanan hayvanı sil(alan dışı)
                                    }
                                }
                            }

                            //++++++++++++kurdun gerisindeki hayvanlar
                            for (int x = j - 1; x > j - 4; x--)
                            {
                                if (x > 0)
                                {
                                    if (AlanOlustur.alan[i, x] == 1.1 || AlanOlustur.alan[i, x] == 1.2 || AlanOlustur.alan[i, x] == 4 || AlanOlustur.alan[i, x] == 5)
                                    {
                                        hayvanlar.Cinsler(AlanOlustur.alan[i,x]);
                                        Console.WriteLine("Kurt, bir " + Hayvanlar.Cins + "  avladı");
                                        AlanOlustur.alan[i, x] = 0;
                                    }
                                }
                            }

                            //+++++++++++++kurdun aşağı tafartaki hayvanlar
                            for (int x = i + 1; x < i + 4; x++)
                            {
                                if (x < 500)
                                {
                                    if (AlanOlustur.alan[x, j] == 1.1 || AlanOlustur.alan[x, j] == 1.2 || AlanOlustur.alan[x, j] == 4 || AlanOlustur.alan[x, j] == 5)
                                    {
                                        hayvanlar.Cinsler(AlanOlustur.alan[x,j]);
                                        Console.WriteLine("Kurt, bir " + Hayvanlar.Cins + "  avladı");
                                        AlanOlustur.alan[x, j] = 0;
                                    }
                                }
                            }

                            //+++++++++++kurdun yukarı tarafındaki hayvanlar
                            for (int x = i - 1; x < i - 4; x--)
                            {
                                if (x > 0)
                                {
                                    if (AlanOlustur.alan[x, j] == 1.1 || AlanOlustur.alan[x, j] == 1.2 || AlanOlustur.alan[x, j] == 4 || AlanOlustur.alan[x, j] == 5)
                                    {
                                        hayvanlar.Cinsler(AlanOlustur.alan[x,j]);
                                        Console.WriteLine("Kurt, bir " + Hayvanlar.Cins + "  avladı");
                                        AlanOlustur.alan[x, j] = 0;
                                    }
                                }
                            }

                        }
                        else if (AlanOlustur.alan[i, j] == 6.1 || AlanOlustur.alan[i, j] == 6.2)
                        {//ASLAN İÇİN İŞLEMLER  <Aslan Koşulu: etrafında 5 birim yakınlıktaki Koyun ve İnek varsa avlar>

                            //-----------aslanın ilerisindeki hayvanlar için
                            for (int x = j + 1; x < j + 5; x++)
                            {//Koşula göre her birim sorgulama için döngümüz
                                if (x < 500)
                                {//sınır belirleme
                                    if (AlanOlustur.alan[i, x] == 1.1 || AlanOlustur.alan[i, x] == 1.2 || AlanOlustur.alan[i, x] == 3.1 || AlanOlustur.alan[i, x] == 3.2)//Sorgulanacak değerler 1 için koyun, 3 için inek varsa
                                    {//Herhangi biri varsa
                                        hayvanlar.Cinsler(AlanOlustur.alan[i,x]);//cinsini nesneye gönder. nesneden cins değişkenine sonu gidecek ve,
                                        Console.WriteLine("Aslan, bir " + Hayvanlar.Cins + "  avladı");//cins değişkeni ekrana yazdırılacak
                                        AlanOlustur.alan[i, x] = 0;//bu hayvan avlandıktan sonra yeri boşalacak
                                    }
                                }
                            }

                            //------------Aslanın gerisindeki hayvanlar için
                            for (int x = j - 1; x > j - 5; x--)
                            {
                                if (x > 0)
                                {
                                    if (AlanOlustur.alan[i, x] == 1.1 || AlanOlustur.alan[i, x] == 1.2 || AlanOlustur.alan[i, x] == 3.1 || AlanOlustur.alan[i, x] == 3.2)
                                    {
                                        hayvanlar.Cinsler(AlanOlustur.alan[i,x]);
                                        Console.WriteLine("Aslan, bir " + Hayvanlar.Cins + "  avladı");
                                        AlanOlustur.alan[i, x] = 0;
                                    }
                                }
                            }

                            //------------Aslanın aşağısındaki hayvanlar için
                            for (int x = i + 1; x < i + 5; x++)
                            {
                                if (x < 500)
                                {
                                    if (AlanOlustur.alan[x, j] == 1.1 || AlanOlustur.alan[x, j] == 1.2 || AlanOlustur.alan[x, j] == 3.1 || AlanOlustur.alan[x, j] == 3.2)
                                    {
                                        hayvanlar.Cinsler(AlanOlustur.alan[x,j]);
                                        Console.WriteLine("Aslan, bir " + Hayvanlar.Cins + "  avladı");
                                        AlanOlustur.alan[x, j] = 0;
                                    }
                                }
                            }

                            //------------Aslanın yukarısında kAlanOlustur.alan hayvanlar için
                            for (int x = i - 1; x > i - 5; x--)
                            {
                                if (x > 0)
                                {
                                    if (AlanOlustur.alan[x, j] == 1.1 || AlanOlustur.alan[x, j] == 1.2 || AlanOlustur.alan[x, j] == 3.1 || AlanOlustur.alan[x, j] == 3.2)
                                    {
                                        hayvanlar.Cinsler(AlanOlustur.alan[x,j]);
                                        Console.WriteLine("Aslan, bir " + Hayvanlar.Cins + "  avladı");
                                        AlanOlustur.alan[x, j] = 0;
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
