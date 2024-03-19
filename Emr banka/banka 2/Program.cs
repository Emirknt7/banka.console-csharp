using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace emrbanka
{
  internal class Emrbanka
    {
        public static decimal dövhesap1 = 1000;
        public static  decimal çeyaltın = 2500;
        public static  decimal yaraltın = 5500;
        public static  decimal tamaltın = 10000;
        public static  decimal gramaltın = 1600;

        public static decimal gramalsayac = 3;
        public static decimal ceyalsayac = 2;
        public static decimal yaralsayac = 1;
        public static decimal tamalsayac = 1;

        public static  decimal dolar = 26.3m;
        public static  decimal euro = 28.6m;

        public static decimal hesap1 = 2000m;
        public static decimal dolarsayac = 25;
        public static decimal eurosayac = 25;

        public static Random elektrik = new Random();
        public static Random su = new Random();
        public static Random doğalgaz = new Random();
        public static Random internet = new Random();

        public static decimal elektrikfa;
        public static decimal sufa;
        public static decimal doğalgazfa;
        public static decimal internetfa;

        public static void dövizişlem()
        {
            Console.Clear();
            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
            Console.WriteLine("döviz almak için 'al' basınız ");
            Console.WriteLine("döviz satmak için 'sat' basınız");
            string alsat = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
            switch (alsat)
            {
                case "al":
                    Console.WriteLine("alınacak dövizin birimini  girin ");
                    Console.WriteLine(" altın alımı için 'a' basın");
                    Console.WriteLine(" dolar için 'd' basın");
                    Console.WriteLine("euro için 'e' basın");
                    char cins = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                    switch (cins)
                    {
                        case 'a':
                            Console.WriteLine("hangi cins altın almak istiyorsunuz ?");
                            Console.WriteLine(" gram altın  alımı için 'g' basın");
                            Console.WriteLine(" ceyrek altın  alımı için 'c' basın");
                            Console.WriteLine(" yarım altın için 'y' basın");
                            Console.WriteLine("tam altın için 't' basın");
                            char al = Convert.ToChar(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            int almik;
                            switch (al)
                            {
                                case 'g':
                                    Console.WriteLine("alınacak tutarı   girin ");
                                    almik = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                    gramalsayac += almik;
                                    Console.WriteLine(" hesapınızdaki  gram altın miktarı= {0}  ", gramalsayac);
                                    System.Threading.Thread.Sleep(2000);
                                    Console.Clear();
                                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                    break;
                                case 'c':
                                    Console.WriteLine("alınacak tutarı   girin ");
                                    almik = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                    ceyalsayac += almik;
                                    Console.WriteLine(" hesapınızdaki  çeyrek altın miktarı=  {0}  ", ceyalsayac);
                                    System.Threading.Thread.Sleep(2000);
                                    Console.Clear();
                                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                    break;
                                case 'y':
                                    Console.WriteLine("alınacak tutarı   girin ");
                                    almik = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                    yaralsayac += almik;
                                    Console.WriteLine(" hesapınızdaki  yarım altın miktarı=   {0}  ", yaralsayac);
                                    System.Threading.Thread.Sleep(2000);
                                    Console.Clear();
                                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                    break;
                                case 't':
                                    Console.WriteLine("alınacak tutarı   girin ");
                                    almik = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                    tamalsayac += almik;
                                    Console.WriteLine(" hesapınızdaki  tam altın miktarı=   {0}  ", tamalsayac);
                                    System.Threading.Thread.Sleep(2000);
                                    Console.Clear();
                                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                    break;
                            }
                            break;

                        case 'd':
                            Console.WriteLine("alınacak tutarı   girin ");
                            almik = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            dolarsayac += almik;
                            Console.WriteLine(" hesapınızdaki  dolar  miktarı=  {0}  ", dolarsayac);
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            break;
                        case 'e':
                            Console.WriteLine("alınacak tutarı   girin ");
                            almik = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            eurosayac += almik;
                            Console.WriteLine(" hesapınızdaki  euro miktarı=   {0} ", eurosayac);
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            break;
                    }
                    break;

                case "sat":
                    Console.WriteLine("sattığınız döviz döviz hesapınızda tl olarak durur");
                    Console.WriteLine("hangi cins altın satmak istiyorsunuz ?");
                    Console.WriteLine(" gram altın  sattımı için 'g' basın");
                    Console.WriteLine(" ceyrek altın  sattımı için 'c' basın");
                    Console.WriteLine(" yarım altın sattımı için 'y' basın");
                    Console.WriteLine("tam altın sattımı için 't' basın");
                    Console.WriteLine("hangi cins döviz satmak istiyorsunuz ?");
                    Console.WriteLine(" dolar  satmak için 'd' basın");
                    Console.WriteLine("euro satamak için 'e' basın");
                    char sat = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                    int satmik;
                    switch (sat)
                    {
                        case 'g':
                            Console.WriteLine("satmak istediğiniz gram altın sayısını giriniz ");
                            satmik = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            if (satmik <= gramalsayac)
                            {
                                dövhesap1 += satmik * gramaltın;
                                gramalsayac -= satmik;
                                Console.WriteLine("döviz hesapınızdaki tutar{0}", dövhesap1);
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            }
                            else { Console.WriteLine("hesapınızda o girdiğiniz tutar yetersiz, hesapta bulunan tutar= {0}", gramalsayac);
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                goto case 'g'; }

                            break;
                        case 'c':
                            Console.WriteLine("satmak istediğiniz çeyrek altın sayısını giriniz ");
                            satmik = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            if (satmik <= ceyalsayac)
                            {
                                dövhesap1 += satmik * çeyaltın;
                                ceyalsayac -= satmik;
                                Console.WriteLine("döviz hesapınızdaki tutar{0}", dövhesap1);
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            }
                            else { Console.WriteLine("hesapınızda o girdiğiniz tutar yetersiz, hesapta bulunan tutar= {0}", ceyalsayac);
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                goto case 'c'; }

                            break;
                        case 'y':
                            Console.WriteLine("satmak istediğiniz yarım altın sayısını giriniz ");
                            satmik = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            if (satmik <= yaralsayac)
                            {
                                dövhesap1 += satmik * yaraltın;
                                yaralsayac -= satmik;
                                Console.WriteLine("döviz hesapınızdaki tutar{0}", dövhesap1);
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            }
                            else { Console.WriteLine("hesapınızda o girdiğiniz tutar yetersiz, hesapta bulunan tutar= {0}", yaralsayac);
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                goto case 'y'; }

                            break;
                        case 't':
                            Console.WriteLine("satmak istediğiniz tam altın sayısını giriniz ");
                            satmik = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            if (satmik <= tamalsayac)
                            {
                                dövhesap1 += satmik * tamaltın;
                                tamalsayac -= satmik;
                                Console.WriteLine("döviz hesapınızdaki tutar{0}", dövhesap1);
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            }
                            else { Console.WriteLine("hesapınızda o girdiğiniz tutar yetersiz, hesapta bulunan tutar= {0}", tamalsayac);
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                goto case 't'; }

                            break;
                        case 'd':
                            Console.WriteLine("satmak istediğiniz dolar sayısını giriniz ");
                            satmik = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            if (satmik <= dolarsayac)
                            {
                                dövhesap1 += satmik * dolar;
                                dolarsayac -= satmik;
                                Console.WriteLine("döviz hesapınızdaki tutar{0}", dövhesap1);
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            }
                            else { Console.WriteLine("hesapınızda o girdiğiniz tutar yetersiz, hesapta bulunan tutar= {0}", dolarsayac);
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                goto case 'd'; }

                            break;
                        case 'e':
                            Console.WriteLine("satmak istediğiniz euro sayısını giriniz ");
                            satmik = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            if (satmik <= eurosayac)
                            {
                                dövhesap1 += satmik * euro;
                                eurosayac -= satmik;
                                Console.WriteLine("döviz hesapınızdaki tutar{0}", dövhesap1);
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            }
                            else { Console.WriteLine("hesapınızda o girdiğiniz tutar yetersiz, hesapta bulunan tutar= {0}", eurosayac);
                                System.Threading.Thread.Sleep(2000);
                                Console.Clear();
                                Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                goto case 'e'; }

                            break;
                    }
                    break;
            }
           
        }
        public static void yatırma()
        {;
            Console.WriteLine("yatırılacak paranın birimini  girin ");
            Console.WriteLine(" dolar için 'd' basın");
            Console.WriteLine("euro için 'e' basın");
            Console.WriteLine(" tele için 't' basın");
            char bir = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
            Console.WriteLine("yatırılacak tutarı   girin ");
            decimal yat = Convert.ToDecimal(Console.ReadLine());
            if (bir == 'd') { dolarsayac += yat; Console.WriteLine("yeni bakiye bu = {0} dolar", dolarsayac); }
            else { if (bir == 'e') { eurosayac += yat; Console.WriteLine("yeni bakiye bu = {0} euro", eurosayac); } else { if (bir == 't') { hesap1 += yat; Console.WriteLine("yeni bakiye bu = {0} tl", hesap1); } } }
           System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
        }
        public static void çekme()
        {
            Console.Clear();
            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
            Console.WriteLine("çekilecek parayı girin ");
            Console.WriteLine("sadece tl çekebilirsiniz");
            decimal çek = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
            if (çek <= hesap1)
            {
                hesap1 -= çek;
                Console.WriteLine("yeni bakiye bu $$ {0} $$", hesap1);
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
            }
            else
            {
                Console.WriteLine("bakiye yetersiz ");
                Console.WriteLine("Yeni  bir tutar girin ");
                Console.Clear();
                Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
            }
        }
        public static void sorgulama()
        {
            Console.Clear();
            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("bakiyeniz $$ {0} $$ tl", hesap1);
            Console.WriteLine(" döviz hesapınızdaki  tüm para  $$ {0} $$ tl", dövhesap1);
            Console.WriteLine(" hesapınızdaki  gram altın miktarı= {0}  ", gramalsayac);
            Console.WriteLine(" hesapınızdaki  çeyrek altın miktarı=  {0}  ", ceyalsayac);
            Console.WriteLine(" hesapınızdaki  yarım altın miktarı=   {0}  ", yaralsayac);
            Console.WriteLine(" hesapınızdaki  tam altın miktarı=   {0}  ", tamalsayac);
            Console.WriteLine(" hesapınızdaki  dolar  miktarı=  {0}  ", dolarsayac);
            Console.WriteLine(" hesapınızdaki  euro miktarı=   {0} ", eurosayac);
        }
        public static void fatura()
        {
            elektrikfa = elektrik.Next(1, 300);
            sufa = su.Next(1, 300);
            doğalgazfa = doğalgaz.Next(1, 500);
            internetfa = internet.Next(1, 300);
            Console.Clear();
            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
            Console.WriteLine("fatura ödeme bölümüne hoşgeldiniz ");
            Console.WriteLine("hangi faturayı ödemek istiyorsunuz ? ");
            Console.WriteLine("elektrik için 'e' basın");
            Console.WriteLine("su için 's' basın");
            Console.WriteLine("doğalgaz için 'd' basın");
            Console.WriteLine("internet için 'i' basın");
            char f=Convert.ToChar(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
            switch (f)
            {
                case 'e':
                    Console.WriteLine("ödenmemiş elektrik faturanız {0} tl ",elektrikfa);
                    Console.WriteLine("elektrik faturasını ödemek için 'ö' basınız");
                    Console.WriteLine("çıkmak için ise herhangi bir tuşa basınız");
                    char b = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                    if (b=='ö')
                    {
                        if (elektrikfa<=hesap1)
                        {
                            hesap1 -= elektrikfa;
                            Console.WriteLine("elektrik faturanız ödenmiştir");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                        }
                        else { Console.WriteLine(" bakiyeniz yetesiz ");Console.WriteLine("bakiyeniz {0} tl",hesap1); }
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");

                    }
                    else
                    {
                        Console.WriteLine("faturanız ödenmemiştir ");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                    }

                    break;
                case 's':
                    Console.WriteLine("ödenmemiş su faturanız {0} tl ", sufa);
                    Console.WriteLine("su faturasını ödemek için 'ö' basınız");
                    Console.WriteLine("çıkmak için ise herhangi bir tuşa basınız");
                    char ğ = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                    if (ğ == 'ö')
                    {
                        if (sufa <= hesap1)
                        {
                            hesap1 -= sufa;
                            Console.WriteLine("su faturanız ödenmiştir");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                        }
                        else { Console.WriteLine(" bakiyeniz yetesiz "); Console.WriteLine("bakiyeniz {0} tl", hesap1); }
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                    }
                    else
                    {
                        Console.WriteLine("faturanız ödenmemiştir ");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                    }
                    break;
                case 'd':
                    Console.WriteLine("ödenmemiş doğalgaz faturanız {0} tl ", elektrikfa);
                    Console.WriteLine("doğalgaz faturasını ödemek için 'ö' basınız");
                    Console.WriteLine("çıkmak için ise herhangi bir tuşa basınız");
                    char l = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                    if (l == 'ö')
                    {
                        if (doğalgazfa <= hesap1)
                        {
                            hesap1 -= doğalgazfa;
                            Console.WriteLine("doğalgaz faturanız ödenmiştir");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                        }
                        else { Console.WriteLine(" bakiyeniz yetesiz "); Console.WriteLine("bakiyeniz {0} tl", hesap1); }
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                    }
                    else
                    {
                        Console.WriteLine("faturanız ödenmemiştir ");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                    }
                    break;
                case 'i':
                    Console.WriteLine("ödenmemiş internet faturanız {0} tl ", elektrikfa);
                    Console.WriteLine("internet faturasını ödemek için 'ö' basınız");
                    Console.WriteLine("çıkmak için ise herhangi bir tuşa basınız");
                    char j = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                    if (j == 'ö')
                    {
                        if (internetfa <= hesap1)
                        {
                            hesap1 -= internetfa;
                            Console.WriteLine("internet faturanız ödenmiştir");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                        }
                        else { Console.WriteLine(" bakiyeniz yetesiz "); Console.WriteLine("bakiyeniz {0} tl", hesap1); }
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                    }
                    else
                    {
                        Console.WriteLine("faturanız ödenmemiştir ");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                    }
                    break;
            }
        }
        static void Main(string[] arg)
        {
            Console.WriteLine("*******************************Emrbanka******************************************\n");

            Console.WriteLine("|***********************kayıt işlemine hoşgeldiniz********************************|");

            Console.WriteLine(" Kayıt için adınızı giriniz ");
            string ad = Console.ReadLine();
            Console.WriteLine("Kayıt için soyadınızı giriniz");
            string soyad = Console.ReadLine();
            Console.WriteLine("Şifrenizi giriniz");
            int şifre = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\akayıt işleminiz başarılı bir şekilde gerçekleşti\n");
            Console.WriteLine("ana sayfaya yönlendiriliyorsunuz ");
            System.Threading.Thread.Sleep(2000);
            const char d = 'd', e = 'e', t = 't'; 
            baş:
            try
            {

                while (true)
                {
                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                    Console.WriteLine("adınızı giriniz ");
                    string a = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                    Console.WriteLine("soyadınızı giriniz");
                    string b = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                    Console.WriteLine("şifrenizi giriniz");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                    int sayac = -1;
                    while (true)
                    {
                        if (ad == a && b == soyad && şifre == c)

                        {
                            Console.WriteLine("\n  hoşgeldiniz {0} bey", ad);
                            Console.WriteLine("********************************");
                            Console.WriteLine(" hesapınızdaki  tüm para  $$ {0} $$ tl", hesap1);
                            Console.WriteLine(" hesapınızdaki  gram altın miktarı= {0}  ", gramalsayac);
                            Console.WriteLine(" hesapınızdaki  çeyrek altın miktarı=  {0}  ", ceyalsayac);
                            Console.WriteLine(" hesapınızdaki  yarım altın miktarı=   {0}  ", yaralsayac);
                            Console.WriteLine(" hesapınızdaki  tam altın miktarı=   {0}  ", tamalsayac);
                            Console.WriteLine(" hesapınızdaki  dolar  miktarı=  {0}  ", dolarsayac);
                            Console.WriteLine(" hesapınızdaki  euro miktarı=   {0} ", eurosayac);
                            Console.WriteLine("**************************************************************************");
                            Console.WriteLine(" Yapmak istediğiniz işlem nedir?\n ");
                            Console.WriteLine("********************************");
                            Console.WriteLine(" para yatırmak için 'Y' basın");
                            Console.WriteLine("para çekmek için 'Ç' basın");
                            Console.WriteLine("döviz alım satım için 'd' basın");
                            Console.WriteLine("fatura ödemesi  için 'f' basın");
                            Console.WriteLine(" hesap sorgulama yapmak için 'S'basın "); break;
                        }
                        else
                        {
                            while (ad != a || soyad != b || şifre != c)
                            {
                                if (a != ad)
                                {
                                    sayac++;
                                    Console.WriteLine("adınızı yanlış girdiniz ");
                                    Console.WriteLine("adınızı tekrar giriniz ");
                                    a = Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                    if (sayac == 2)
                                    {
                                        Console.WriteLine("hatalı giriş yaptığınız için adınız bloke olmuştur");
                                        Console.WriteLine("bloke olan kullanıcı hesapından 5 tl ücret cezası vardır kartınızdan bu ücret çekilecek");
                                        Console.WriteLine("lütfen sizden istenileni uygun yere yazın");
                                        Console.Clear();
                                        Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                        hesap1 -= 5;
                                        break;
                                    }
                                }
                                else if (b != soyad)
                                {
                                    sayac++;
                                    Console.WriteLine("soyadınızı yanlış girdiniz ");
                                    Console.WriteLine("soyadınızı tekrar giriniz");
                                    b = Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                    if (sayac == 2 || sayac == 4)
                                    {
                                        Console.WriteLine("hatalı giriş yaptığınız için adınız bloke olmuştur");
                                        Console.WriteLine("bloke olan kullanıcı hesapından 5 tl ücret cezası vardır kartınızdan bu ücret çekilecek");
                                        Console.WriteLine("lütfen sizden istenileni uygun yere yazın");
                                        Console.Clear();
                                        Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                        hesap1 -= 5;

                                        break;
                                    }
                                }
                                else if (c != şifre)
                                {
                                    sayac++;
                                    Console.WriteLine("şifrenizi yanlış girdiniz ");
                                    Console.WriteLine("şifrenizi tekrar giriniz ");
                                    c = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                    if (sayac == 2 || sayac == 4 || sayac == 6)
                                    {
                                        Console.WriteLine("hatalı giriş yaptığınız için adınız bloke olmuştur");
                                        Console.WriteLine("bloke olan kullanıcı hesapından 5 tl ücret cezası vardır kartınızdan bu ücret çekilecek");
                                        Console.WriteLine("lütfen sizden istenileni uygun yere yazın");
                                        Console.Clear();
                                        Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                        hesap1 -= 5;

                                        break;
                                    }
                                }
                            }
                        }
                    }
                    switch (Console.ReadLine())
                    {
                        case "y":
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            yatırma();
                            Console.WriteLine("yapmak istediğiniz başka bir işlem var mı ?");
                            Console.WriteLine(" evet için 'e' basın");
                            Console.WriteLine("hayır için 'h' basın");
                            char w = Convert.ToChar(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            if (w == 'e')
                            {
                                Console.WriteLine(" yapmak istediğiniz işlem nedir ?");
                                Console.WriteLine(" para yatırmak için 'Y' basın");
                                Console.WriteLine("para çekmek için 'Ç' basın");
                                Console.WriteLine("döviz almak için 'd' basın");
                                Console.WriteLine("fatura ödemesi  için 'f' basın");
                                Console.WriteLine(" hesap sorgulama yapmak için 'S'basın ");
                                char n = Convert.ToChar(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                if (n == 'y')
                                {
                                    goto case "y";
                                }
                                else
                                {
                                    if (n == 'ç')
                                    {
                                        goto case "ç";
                                    }
                                    else { if (n == 'd') { goto case "d"; } else { if (n == 's') { goto case "s"; } else { if (n == 'f') { goto case "f"; } } } }
                                }
                            }
                            else
                            {
                                if (w == 'h')
                                {
                                    Console.Clear();
                                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                    Console.WriteLine(" bizi tercih ettiğiniz için teşekkür ederiz");
                                    Console.WriteLine(" yine bekleriz ");
                                }
                            }
                            break;
                        case "d":
                            dövizişlem();
                            Console.WriteLine("yapmak istediğiniz başka bir işlem var mı ?");
                            Console.WriteLine(" evet için 'e' basın");
                            Console.WriteLine("hayır için 'h' basın");
                            char q = Convert.ToChar(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            if (q == 'e')
                            {
                                Console.WriteLine(" yapmak istediğiniz işlem nedir ?");
                                Console.WriteLine(" para yatırmak için 'Y' basın");
                                Console.WriteLine("para çekmek için 'Ç' basın");
                                Console.WriteLine("döviz almak için 'd' basın");
                                Console.WriteLine("fatura ödemesi  için 'f' basın");
                                Console.WriteLine(" hesap sorgulama yapmak için 'S'basın ");
                                char n = Convert.ToChar(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                if (n == 'y')
                                {
                                    goto case "y";
                                }
                                else
                                {
                                    if (n == 'y')
                                    {
                                        goto case "ç";
                                    }
                                    else { if (n == 'd') { goto case "d"; } else { if (n == 's') { goto case "s"; } else { if (n == 'f') { goto case "f"; } } } }
                                }
                            }
                            else
                            {
                                if (q == 'h')
                                {
                                    Console.Clear();
                                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                    Console.WriteLine("********************************");
                                    Console.WriteLine(" bizi tercih ettiğiniz için teşekkür ederiz");
                                    Console.WriteLine(" yine bekleriz ");
                                }
                            }
                            break;
                        case "ç":
                            çekme();
                            Console.WriteLine("yapmak istediğiniz başka bir işlem var mı ?");
                            Console.WriteLine(" evet için 'e' basın");
                            Console.WriteLine("hayır için 'h' basın");
                            char u = Convert.ToChar(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            if (u == 'e')
                            {
                                Console.WriteLine(" yapmak istediğiniz işlem nedir ?");
                                Console.WriteLine(" para yatırmak için 'Y' basın");
                                Console.WriteLine("para çekmek için 'Ç' basın");
                                Console.WriteLine("döviz almak için 'd' basın");
                                Console.WriteLine("fatura ödemesi  için 'f' basın");
                                Console.WriteLine(" hesap sorgulama yapmak için 'S'basın ");
                                char n = Convert.ToChar(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                if (n == 'y')
                                {
                                    goto case "y";
                                }
                                else
                                {
                                    if (n == 'ç')
                                    {
                                        goto case "ç";
                                    }
                                    else { if (n == 'd') { goto case "d"; } else { if (n == 's') { goto case "s"; } else { if (n == 'f') { goto case "f"; } } } }
                                }
                            }
                            else
                            {
                                if (u == 'h')
                                {
                                    Console.Clear();
                                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                    Console.WriteLine(" bizi tercih ettiğiniz için teşekkür ederiz");
                                    Console.WriteLine(" yine bekleriz ");
                                }
                            }
                            break;
                        case "s":
                            sorgulama(); System.Threading.Thread.Sleep(5000);
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            Console.WriteLine("yapmak istediğiniz başka bir işlem var mı ?");
                            Console.WriteLine(" evet için 'e' basın");
                            Console.WriteLine("hayır için 'h' basın");
                            char k = Convert.ToChar(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            if (k == 'e')
                            {
                                Console.WriteLine(" yapmak istediğiniz işlem nedir ?");
                                Console.WriteLine(" para yatırmak için 'Y' basın");
                                Console.WriteLine("para çekmek için 'Ç' basın");
                                Console.WriteLine("döviz almak için 'd' basın");
                                Console.WriteLine("fatura ödemesi  için 'f' basın");
                                Console.WriteLine(" hesap sorgulama yapmak için 'S'basın ");
                                char n = Convert.ToChar(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                if (n == 'y')
                                {
                                    goto case "y";
                                }
                                else
                                {
                                    if (n == 'y')
                                    {
                                        goto case "ç";
                                    }
                                    else { if (n == 'd') { goto case "d"; } else { if (n == 's') { goto case "s"; } else { if (n == 'f') { goto case "f"; } } } }
                                }
                            }
                            else
                            {
                                if (k == 'h')
                                {
                                    Console.Clear();
                                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                    Console.WriteLine(" bizi tercih ettiğiniz için teşekkür ederiz");
                                    Console.WriteLine(" yine bekleriz ");
                                }
                            }
                            break;
                        case "f":
                            fatura();
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            Console.WriteLine("yapmak istediğiniz başka bir işlem var mı ?");
                            Console.WriteLine(" evet için 'e' basın");
                            Console.WriteLine("hayır için 'h' basın");
                            char h = Convert.ToChar(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                            if (h == 'e')
                            {
                                Console.WriteLine(" yapmak istediğiniz işlem nedir ?");
                                Console.WriteLine(" para yatırmak için 'Y' basın");
                                Console.WriteLine("para çekmek için 'Ç' basın");
                                Console.WriteLine("döviz almak için 'd' basın");
                                Console.WriteLine("fatura ödemesi  için 'f' basın");
                                Console.WriteLine(" hesap sorgulama yapmak için 'S'basın ");
                                char n = Convert.ToChar(Console.ReadLine());
                                Console.Clear();
                                Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                if (n == 'y')
                                {
                                    goto case "y";
                                }
                                else
                                {
                                    if (n == 'ç')
                                    {
                                        goto case "ç";
                                    }
                                    else { if (n == 'd') { goto case "d"; } else { if (n == 's') { goto case "s"; } else { if (n == 'f') { goto case "f"; } } } }
                                }
                            }
                            else
                            {
                                if (h == 'h')
                                {
                                    Console.Clear();
                                    Console.WriteLine("***********************Emrbanka hoşgeldiniz********************************");
                                    Console.WriteLine(" bizi tercih ettiğiniz için teşekkür ederiz");
                                    Console.WriteLine(" yine bekleriz ");
                                }
                            }
                            break;

                    }

                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("hatalı tuş takımı girdiniz sistem sizi 3 dk sonra ana sayfaya atacak");
                System.Threading.Thread.Sleep(3000);
                goto baş;

            }
            finally
            {
                Console.WriteLine("bizi tercih ettiğiniz için teşekür ederiz ");
            }
           
        }
    }
}



















