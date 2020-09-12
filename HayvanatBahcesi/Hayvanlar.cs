using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    //bu sınıfımızda  hangi hayvandan kaç adet olduğunu ve cinsiyet farklılığını belirtmek için kullanmaktayız.
    // bu bölüm adet sayısı olarak başlangıçta hayvanları oluşturmak ve alana dağıtmak için kullanılıyor. daha sonra cinsler için farklı yerlerde de kullanılmıştır.
    public class Hayvanlar
    {
        public static string Cins = ""; //globalde her yerde kullanabileceğim değişken. double gönderdiğim bir metoddan string değer dönderemem fakat bu değişkene atabilirim. böyle bir çözüm sağlamaktadır.
        public int Koyun()
        {
            //koyun için 
            int adet = 30;
            return adet;
        }
        public int Kurt()
        {
            //kurt için
            int adet = 10;
            return adet;
        }
        public int Inek()
        {
            //inek için 
            int adet = 10;
            return adet;
        }
        public int Tavuk()
        {
            //tavuk için
            int adet = 10;
            return adet;
        }
        public int Horoz()
        {
            //horoz için
            int adet = 10;
            return adet;
        }
        public int Aslan()
        {
            //aslan için
            int adet = 8;
            return adet;
        }
        public int Avcı()
        {
            //avcı için
            int adet = 1;
            return adet;
        }
        public void Cinsler(double gelen)
        {//bu metod da hayvanların cinslerini belirtmek için kullanıyoruz. örneğin, 1 ıd si koyuna ait. 1.1 erkek koyun 1.2 dişi koyun için tanımlamadır.
            if (gelen == 1.1)
            {//1 koyun
                //0.1 durumu erkek için
                Cins = "Erkek koyun";
            }
            else if (gelen == 1.2)
            {//0.2 durumu dişi  için
                Cins = "Dişi Koyun";
            }
            else if (gelen == 2.1)
            {//2 kurt
                //0.1 durumu erkek için
                Cins = "Erkek Kurt";
            }
            else if (gelen == 2.2)
            {//0.2 durumu dişi  için
                Cins = "Dişi Kurt";
            }
            else if (gelen == 3.1)
            {//3 inek
                //0.1 durumu erkek için
                Cins = "Erkek İnek";
            }
            else if (gelen == 3.2)
            { //0.2 durumu dişi  için
                Cins = "Dişi İnek";
            }
            else if (gelen == 4)
            {//4 Tavuk  için id
                Cins = "Tavuk";
            }
            else if (gelen == 5)
            {//5 Horoz  için id
                Cins = "Horoz";
            }
            else if (gelen == 6.1)
            {//6 Aslan
                //0.1 durumu erkek için
                Cins = "Erkek Aslan";
            }
            else if (gelen == 6.2)
            {//0.2 durumu dişi  için
                Cins = "Dişi Aslan";
            }
            else if (gelen == 7)
            {//7 avcı için id
                Cins = "Avcı";
            }
            else
            {
                Cins = "";
            }
        }
    }
    
}
