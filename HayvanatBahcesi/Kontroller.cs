using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanatBahcesi
{
    //MAIN TARAFINDAN GELEN 2 ADET SINIF KONTROLÜ
    public class Kontroller
    {
        public static Random rnd = new Random();//Random Kütüphanesi nesnesi
        public static Hareketler hareketler = new Hareketler();//Hareketleri almak için çağırılan Hareketler sınıfı nesnesi
        public static HayvanOlusmasi holus = new HayvanOlusmasi();//Hayvanların Koşullar dahilinde meydana gelmesi işlemleri için HayvanOluşması Sınıfı Nesnesi. sınıfı nesnesi
        public void KontrolHayvanOlusturma()
        {//hayvan oluşturması alanına gitmesi gereken değerleri her hayvan için tek tek gönderip işlem yaptırıyoruz
            holus.Olusma(1.1, 1.2);
            holus.Olusma(2.1, 2.2);
            holus.Olusma(3.1, 3.2);
            holus.Olusma(4, 5);
            holus.Olusma(5, 4);
            holus.Olusma(6.1, 6.2);
        }
        public void KontrolHayvanHareketi()
        {//hayvan hareketleri alanına gitmesi gereken değerleri her hayvan için tek tek gönderip işlem yaptırıyoruz
            hareketler.CtrlHareket(1.1, 1.2, 1);
            hareketler.CtrlHareket(2.1, 2.2, 2);
            hareketler.CtrlHareket(3.1, 3.2, 3);
            hareketler.CtrlHareket(4, 4, 4);
            hareketler.CtrlHareket(5, 5, 5);
            hareketler.CtrlHareket(6.1, 6.2, 6);
            hareketler.CtrlHareket(7, 7, 7);
        }
    }
}
