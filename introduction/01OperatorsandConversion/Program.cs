using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01OperatorsandConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AritmetikIslemler();

            //MantiksalIslemler();

            //ConvertIslemler();

            //CastIslemler();

            //BoxingUnboxing();

            //Ornekler();

            //Ornekler2();

            //Ornekler3();

            Console.ReadKey();

        }
        static void Ayrac()
        {
            int karakterSayi = 15;
            string ayrac = new String('-', karakterSayi);

            Console.WriteLine(ayrac);
        }

        private static void AritmetikIslemler()
        {
            int sayi1 = 15;
            int sayi2 = 23;

            double sonuc = (sayi1 * 1.0 / sayi2);

            Console.WriteLine("----Aritemetik İşlemler----");
            Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, (sayi1 + sayi2));
            Console.WriteLine("{0} - {1} = {2}", sayi1, sayi2, (sayi1 - sayi2));
            Console.WriteLine("{0} * {1} = {2}", sayi1, sayi2, (sayi1 * sayi2));
            Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, (sayi1 / sayi2));
            Console.WriteLine("{0} % {1} = {2}", sayi1, sayi2, (sayi1 % sayi2));


            Ayrac();

            int a = 5;
            int b = 6;

            b += a;  //b = b + a
            b -= a;  //b = b - a
            b *= a;  //b = b * a
            b /= a;  //b = b / a
            b %= a;  //b = b % a
            Console.WriteLine(b);

            Ayrac();

            int c = 7;
            int d = 7;
            int e = 7;

            // c += 1; or not c++;

            c = c + 1; //8
            d += 1;  //8


            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e++); // Değişken ardında gelen e++ işlemi önce değişkenin e'in değerini yazar(o an ki işlemi yapar) sonra değerini bir aratırır.
            Console.WriteLine(++e); // Değişken önce gelen ++e işlemi önce değişkenin e'in değerini değerini bir aratırır sonra değerini yazar(o an ki işlemi yapar)
            Console.WriteLine(e);

            Ayrac();

            e = 7;
            int x = e++; // 7
            int y = e;   // 8
            int z = ++e; // 9
            int q = e;   // 9

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(q);

            Ayrac();

            x = e--; // 9
            y = e;   // 8
            z = --e; // 7 
            q = e;   // 7

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(q);

            Console.ReadLine();

        }
        private static void MantiksalIslemler()
        {
            // karsılastırma operatorleri
            // >, <, !=, <=, >=, !

            int x = 10;
            int y = 23;

            bool kontrol1 = (x > y);    //false
            bool kontrol2 = (x < y);    // true
            bool kontrol3 = (x != y);   // true
            bool kontrol4 = (x <= y);   // true
            bool kontrol5 = (x >= y);   // false

            Console.WriteLine(kontrol1);
            Console.WriteLine(kontrol2);
            Console.WriteLine(kontrol3);
            Console.WriteLine(kontrol4);
            Console.WriteLine(kontrol5);

            bool kontrol6 = (x % 2 == 0);   //true
            bool kontrol7 = (y % 2 == 0);    // false
            bool kontrol8 = (!(y % 2 == 0));   //true

            Console.WriteLine(kontrol6);
            Console.WriteLine(kontrol7);
            Console.WriteLine(kontrol8);

            Ayrac();

            int a = 125;
            int b = 374;

            bool kontrol9 = (a > 100 && b < 275); // t && F => F
            bool kontrol10 = (a > 300 || b < 575); // T || F => T

            Ayrac();

            bool kontrol11 = (a > 150 && b < 375 && checkA(a) && b < 275);
            bool kontrol12 = (a > 150 & b < 375 & checkA(a) & b < 275);


        }
        private static bool checkA(int sayi)
        {
            return sayi > 100;
        }

        private static void ConvertIslemler()
        {
            string sayiStr = "5";
            string doubleStr = "5.0";

            int sayiInt = Convert.ToInt32(sayiStr);
            int sayi2Int = int.Parse(sayiStr);

            double sayiDouble1 = Convert.ToDouble(doubleStr);
            double sayiDouble2 = Convert.ToDouble(sayiInt);



            Console.WriteLine(sayiStr + " Type :" + sayiStr.GetType().Name);
            Console.WriteLine(sayiInt + " Type :" + sayiInt.GetType().Name);
            Console.WriteLine(sayi2Int + " Type :" + sayi2Int.GetType().Name);
            Console.WriteLine(sayiDouble1 + " Type :" + sayiDouble1.GetType().Name);
            Console.WriteLine(sayiDouble2 + " Type :" + sayiDouble2.GetType().Name);

            Ayrac();
            DateTime dt = Convert.ToDateTime("04.01.2024");

            Console.WriteLine(dt.ToString("MMMM"));
            Console.WriteLine(System.Globalization.CultureInfo.CurrentCulture);

            if (System.Globalization.CultureInfo.CurrentCulture.ToString() == "tr-TR")
            {
                // Türkçe diline uygun formatlamalar çalışır.
            }

            Ayrac();

            int ogrenciNo = 123456;

            string ogrNO = Convert.ToString(ogrenciNo);
            ogrNO = ogrenciNo.ToString();

            bool check = true;
            string kontrol = check.ToString();


            Console.WriteLine("Öğrenci No: " + ogrenciNo);


        }

        private static void CastIslemler()
        {
            int sayi1 = 100;
            int sayi2 = sayi1;

            double sayi3 = sayi2; //Implicit Bilinçsiz dönüşüm.

            short sayi4 = (short)sayi3; //Explicit Bilinçli dönüşüm.

            int sayi5 = 27956;

            short sayi6 = (short)sayi5;

            Console.WriteLine(sayi5);
            Console.WriteLine(sayi6);

            Console.WriteLine(sayi5 - short.MaxValue);
            Console.WriteLine(short.MinValue + (sayi5 - short.MaxValue));
        }

        private static void BoxingUnboxing()
        {
            int a = 5;
            string b = "5";
            //b = 5;

            object c = a;

            Console.WriteLine(c.GetType().Name);
            c = true;

            Console.WriteLine(c.GetType().Name);

            c = b;

            Console.WriteLine(c.GetType().Name);

            //object d;

            //d = 5;

            //Console.WriteLine(d.GetType().Name);


            var sayi = false;


            Console.WriteLine(c.GetType().Name);


            double d = (double)((int)c) + 5.0;

            Console.WriteLine(d);


        }
        private static void Ornekler()
        {

            Ayrac();
            //iki tanı sayı, girilene kadar dogru gir desin




            Console.WriteLine("İki adet tam sayı girin: ");

            bool control = true;

            while (control)
            {

                bool a = int.TryParse(Console.ReadLine(), out int sayi1);
                bool b = int.TryParse(Console.ReadLine(), out int sayi2);

                if (a && b)
                {
                    control = false;
                    Console.WriteLine("Toplam : " + (sayi1 + sayi2));
                }

                else
                {
                    control = true;
                    Console.WriteLine("Hatalı formatta bir sayı girişinde bulundun.");
                }

            }
            Ayrac();



            //kullanıcıdan aylık maas
            //yıllık maası 200k üstüyse 0.4 vergi
            //300k üstü 0.5
            //500k üstü 0.6
            // yıllık maas: ödeyeceği vergi: ve kalan maas:

            Console.WriteLine("Aylık maaşınızı girin:");
            double maas = Convert.ToDouble(Console.ReadLine());

            double yillik = maas * 12;


            if (yillik >= 500)
            {
                double vergi = yillik * 0.6;

                double kalan = yillik - vergi;

                Console.WriteLine("Aylık maaşınız:" + maas);
                Console.WriteLine("Yıllık maaşınız:" + yillik);
                Console.WriteLine("Vergi miktarı:" + vergi);
                Console.WriteLine("Kalan maaşınız:" + kalan);
            }
            else if (500 > yillik && yillik >= 300)
            {
                double vergi = yillik * 0.5;

                double kalan = yillik - vergi;

                Console.WriteLine("Aylık maaşınız:" + maas);
                Console.WriteLine("Yıllık maaşınız:" + yillik);
                Console.WriteLine("Vergi miktarı:" + vergi);
                Console.WriteLine("Kalan maaşınız:" + kalan);
            }
            else if (300 > yillik && yillik >= 200)
            {
                double vergi = yillik * 0.4;

                double kalan = yillik - vergi;

                Console.WriteLine("Aylık maaşınız:" + maas);
                Console.WriteLine("Yıllık maaşınız:" + yillik);
                Console.WriteLine("Vergi miktarı:" + vergi);
                Console.WriteLine("Kalan maaşınız:" + kalan);
            }
            else
            {
                Console.WriteLine("Aylık maaşınız:" + maas);
                Console.WriteLine("Yıllık maaşınız:" + yillik);
                Console.WriteLine("Vergi miktarı: Vergi ödenmiyor.");
                Console.WriteLine("Kalan maaşınız: " + yillik);
            }

            Ayrac();


            bool control1 = true;

            while (control1)
            {
                control1 = !float.TryParse(Console.ReadLine(), out float aylik);

                if (!control1)
                {
                    float totalSalary = aylik * 12;
                    float ratio = 0.0f;
                    if (totalSalary > 20000)
                    {
                        ratio = 0.4f;
                    }
                    if (totalSalary > 30000)
                    {
                        ratio = 0.5f;
                    }
                    if (totalSalary > 50000)
                    {
                        ratio = 0.6f;
                    }

                    Console.WriteLine("toplam maas " + totalSalary);
                    Console.WriteLine("vergi miktarı " + (totalSalary * ratio));
                    Console.WriteLine("kalan maas " + (totalSalary - (totalSalary * ratio)));
                }
                else
                {
                    Console.WriteLine("gecersiz bir maas girisi yaptınız tekrar deneyin.");
                }

            }



        }

        private static void Ornekler2()
        {
            /* parkur uzunlugu gir metre
            *kac tur kostugunu gir
            *kosu mesafesi km
            */

            Console.WriteLine("Parkur uzunluğunu girin: ");

            double parkur = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kaç tur koştuğunuzu girin: ");

            double tur = Convert.ToInt32(Console.ReadLine());

            double km = tur * parkur;

            double km1 = km / 1000;

            Console.WriteLine("Toplam koşu km: " + km1);

            Ayrac();




            bool control = true;

            while (control)
            {
                Console.WriteLine("parkur uzunlugu girin m cinsinden");
                bool a = int.TryParse(Console.ReadLine(), out int metre);
                Console.WriteLine("tur sayısını girin");
                bool b = int.TryParse(Console.ReadLine(), out int tur1);

                if (a && b)
                {
                    control = false;

                    float total = metre * tur1;

                    Console.WriteLine("toplam kosunuz " + (total / 1000.0) + " kmdir.");

                }
                else
                {
                    Console.WriteLine("hatalı bir veri girişi yaptınız tekrar deneyin");
                }
            }


        }

        private static void Ornekler3()
        {
            char c = 'a';
            int a = c;
            ++a;

            char b = (char)a;
            Console.WriteLine(b);

        }

    }
}
