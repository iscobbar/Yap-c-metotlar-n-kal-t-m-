using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katilim_2
{
    //Yapıcı metotların kalıtımı

    class Program
    {
        static void Main(string[] args)
        {
            arac a1 = new arac("Mercedes", "A3", "2000", "siyah", 4, "Diesel", 'B');
            kamyon k1 = new kamyon(2200, "Volvo", "k40", "4500", "gri", 12, "mazot", 'E');
            ckamyonu ck1 = new ckamyonu(1500, 2200, "Scania", "XC840", "6500", "Sari", 8, "mazot", 'E');

            Console.WriteLine("kamyonun bilgileri aşağıdaki gibidir.");
            Console.WriteLine(k1.Araçtipi);
            Console.WriteLine(k1.Marka);
            Console.WriteLine(k1.Model);
            Console.WriteLine(k1.Motorhacmi);
            Console.WriteLine(k1.Renk);
            Console.WriteLine(k1.Tekerleksayisi);
            Console.WriteLine(k1.Yakittipi);
            Console.WriteLine(k1.Araçtipi);
            Console.WriteLine();
            Console.WriteLine("çöp kamyonunun bilgileri aşağıdaki gibidir");
            Console.WriteLine(ck1.presskuvveti);
            Console.WriteLine(ck1.Araçtipi);
            Console.WriteLine(ck1.Marka);
            Console.WriteLine(ck1.Model);
            Console.WriteLine(ck1.Motorhacmi);
            Console.WriteLine(ck1.Renk);
            Console.WriteLine(ck1.Tekerleksayisi);
            Console.WriteLine(ck1.Yakittipi);
            Console.WriteLine(ck1.Araçtipi);


            Console.Read();
        }
    }
    class arac
    {
        public string Marka;
        public string Model;
        public string Motorhacmi;
        public string Renk;
        public byte Tekerleksayisi;
        public string Yakittipi;
        public char Araçtipi;
        // motor:A otomobil:B otobüs:D tır:E
        public arac() { }
        //alt sınıfta yapıcı metot kullanırken base anahtar kelimesi ile üst sınıftki yapıcı lazım olan parametleri belirliyoruz.
        public arac(string marka, string model, string motorhacmi, string renk, byte tkrsayisi, string yakittipi, char araçtipi)
        {
            this.Marka = marka;
            this.Model = model;
            this.Motorhacmi = motorhacmi;
            this.Renk = renk;
            this.Tekerleksayisi = tkrsayisi;
            this.Yakittipi = yakittipi;
            this.Araçtipi = araçtipi;
        }
    }
    class kamyon : arac
    {
        public short DTkapasitesi;
        public kamyon() { }
        public kamyon(short dorsekapasite, string marka, string model, string motorhacmi, string renk, byte tkrsayisi, string yakittipi, char araçtip) :
            base(marka, model, motorhacmi, renk, tkrsayisi, yakittipi, araçtip)
        {
            this.DTkapasitesi = dorsekapasite;
        }
        //araçtipi: yük/hafriyat/çekici
        new public string Araçtipi;
        new public char a_araçtipi
        {
            get { return base.Araçtipi; }
            set { base.Araçtipi = value; }
        }
    }
    class ckamyonu : kamyon
    {
        public short Presskuvveti;
        public ckamyonu() { }
        public ckamyonu(short presskuvveti, short dorsekapasite, string marka, string model, string motorhacmi, string renk, byte tkrsayisi, string yakittipi, char araçtip) :
            base(dorsekapasite, marka, model, motorhacmi, renk, tkrsayisi, yakittipi, araçtip)
        {
            this.Presskuvveti = presskuvveti;
        }
    }

}
