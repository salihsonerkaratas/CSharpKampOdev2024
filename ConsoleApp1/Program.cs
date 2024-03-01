using Business.Concrete;
using Entities.Concrete;

class Program
{
    static void Main(string[] args)
    {
        /*string mesaj = "Merhaba";
        double tutar = 1000; //db bağlantısı
        int sayi = 100;
        bool GirisYapilmisMi = false;

        string ad = "Salih";
        string soyad = "Soner";
        int dogumYili = 1995;
        long tcNo = 1234567890;

        Console.WriteLine(tutar * 1.18);
        Console.WriteLine(tutar * 1.18); */

        /*SelamVer(isim: "Engin");
        SelamVer(isim: "Ahmet");
        SelamVer(isim: "Selin");
        SelamVer();*/

        int sonuc = Topla(3);

        //Arrays
        /*string ogrenci1 = "Engin";
        string ogrenci2 = "Kerem";
        string ogrenci3 = "Berkay";

        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Engin";
        ogrenciler[1] = "Kerem";
        ogrenciler[2] = "Berkay";

        //referans tipler: Array, class, interface, abstract
        ogrenciler = new string[4];
        ogrenciler[3] = "Ozan";

        string[] sehirler1 = new string[] { "Ankara", "İstanbul", "İzmir" };
        string[] sehirler2 = new string[] { "Bursa", "Antalya", "Diyarbakır" };
        sehirler2 = sehirler1;
        sehirler1[0]="Adana";
        Console.WriteLine(sehirler2[0]);*/

        Person person1 = new Person();
        person1.FirtName = "SALİH SONER";
        person1.LastName = "KARATAŞ";
        person1.DateOfBirthYear = 1995;
        person1.Nationaldentity = 14909831702;


        /*for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        foreach (string sehir in sehirler1)
        {
            Console.WriteLine(sehir);
        }*/

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);
        
        Console.ReadLine();
    }

    //Vatandas vatandas1 = new Vatandas();

    /*public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

    }*/

    

    static void SelamVer(string isim = "isimsiz")
    {
        Console.WriteLine("Merhaba " + isim);
    }

    static int Topla(int sayi1 = 4, int sayi2 = 2)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam Verilecek Maske: " + sonuc);
        return sonuc;
    }
}