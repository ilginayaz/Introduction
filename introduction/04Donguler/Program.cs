using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dongu1();
            //Dongu2();
            //Dongu3();

            //Dongu4();

            //Dongu5();

            //Dongu6();

            //Dongu6ek();

            //Dongu7();

            //Dongu8();

            //Dongu9();

            //Dongu10();

            //Dongu11();

            //Dongu12();

            //Dongu13();

            // Dongu14();
           
            //Dongu15();

            //Dongu16();

            //Dongu17();
            //Ornek1();
            //Ornek2();
            //Ornek3();
            //Ornek4();
            //Ornek5();
            //Ornek6();
            //Ornek7();


            Console.ReadLine();

        }

        static void Dongu1()
        {
            //int limit = int.Parse(Console.ReadLine());

            //for (int i = 0; i < 10; i++)
            //{
            //    //Console.WriteLine((new Random().Next(10) + 1));
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    //Console.WriteLine((new Random().Next(10) + 1));
            //    Console.WriteLine(i);
            //}


            //for (int i = 10; i <= 10; i++)
            //{
            //    //Console.WriteLine((new Random().Next(10) + 1));
            //    Console.WriteLine(i);
            //}

            //for (int i = 10; i > 0; i--)
            //{
            //    //Console.WriteLine((new Random().Next(10) + 1));
            //    Console.WriteLine(i);
            //}

            for (int i = 1; i <= 10; ++i)
            {
                //Console.WriteLine((new Random().Next(10) + 1));
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------");

            for (int i = 1; i <= 10;)
            {
                ++i;
                //Console.WriteLine((new Random().Next(10) + 1));
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------");

            for (int i = 1; i <= 10;)
            {
                i = i * 2;
                //Console.WriteLine((new Random().Next(10) + 1));
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------");

            for (int i = 1; i <= 10;)
            {
                i = i + 2;
                //Console.WriteLine((new Random().Next(10) + 1));
                Console.WriteLine(i);
            }


            Console.WriteLine("-----------");

            for (int i = 1; i <= 10;)
            {

                //Console.WriteLine((new Random().Next(10) + 1));
                Console.WriteLine(i);
                i = i + 2;
            }

            Console.WriteLine("-----------");

            for (int i = 1; i <= 10; i = i + 2)
            {

                //Console.WriteLine((new Random().Next(10) + 1));
                Console.WriteLine(i);
            }
        }
        static void Dongu2()
        {
            Console.WriteLine("Limit : ");
            //Hata yaklaması yapılarak iyileştirme yapıldı.
            try
            {
                int limit = int.Parse(Console.ReadLine());

                for (int i = 0; i < limit; i++)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Dongu3()
        {
            Console.WriteLine("Limit : ");
            int limit;
            int.TryParse(Console.ReadLine(), out limit);

            for (int i = 0; i < limit; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("limit : {0}" + limit);
        }
        static void Dongu4()
        {
            int start, end;

            Console.WriteLine("start: ");
            int.TryParse(Console.ReadLine(), out start);
            Console.WriteLine("End: ");
            int.TryParse(Console.ReadLine(), out end);
        }
            
        private static void Dongu5()
            {
                int start, end;

                Console.Write("Start : ");
                int.TryParse(Console.ReadLine(), out start);
                Console.Write("End : ");
                int.TryParse(Console.ReadLine(), out end);

                if (start < end)
                {
                    for (int i = start; i < end; i++)
                    {
                        Console.WriteLine("{0}. deger {1}", i, i);
                    }
                }
                else
                    Console.WriteLine("Başlangıç değer bitiş değerinden büyük olamaz");


            }

        private static void Dongu6()
        {
            int start, end;

            Console.Write("Start : ");
            int.TryParse(Console.ReadLine(), out start);
            Console.Write("End : ");
            int.TryParse(Console.ReadLine(), out end);

            if (start < end)
            {
                //Koşul içinde tek sayıları mod(%) yardımı ile bulmak
                //for (int i = start; i < end; i++)
                //{
                //    //Tek sayıları ekrana yazdırmak
                //    if (i % 2 == 1)
                //        Console.WriteLine(i);
                //}

                if (start % 2 == 0) { start = start + 1; }

                for (int i = start; i < end; i = i + 2)
                {

                    //if (start % 2 == 0)
                    //{
                    //    i = i + 1;
                    //    //Tek sayıları ekrana yazdırmak
                    //    Console.WriteLine(i);

                    //}
                    //else
                    //{
                    //    //Tek sayıları ekrana yazdırmak
                    //    Console.WriteLine(i);
                    //    i = i + 2;
                    //}
                    Console.WriteLine(i);

                }
            }
            else
                Console.WriteLine("Başlangıç değer bitiş değerinden büyük olamaz");
        }

        private static void Dongu7()
        {
            int start, end, artim;

            Console.Write("Start : ");
            int.TryParse(Console.ReadLine(), out start);
            Console.Write("End : ");
            int.TryParse(Console.ReadLine(), out end);
            Console.Write("Artım : ");
            int.TryParse(Console.ReadLine(), out artim);

            if (start < end)
            {
                for (int i = start; i < end; i = i + artim)
                {
                    Console.WriteLine(i);
                }
            }
            else
                Console.WriteLine("Başlangıç değer bitiş değerinden büyük olamaz");
        }
        private static void Dongu8()
        {
            int start, end;

            Console.Write("Start : ");
            int.TryParse(Console.ReadLine(), out start);
            Console.Write("End : ");
            int.TryParse(Console.ReadLine(), out end);

            if (start < end)
            {
                for (int i = start; i < end; i++)
                {
                    if (i % 2 == 0)
                        continue;

                    Console.WriteLine(i);
                }
            }
            else
                Console.WriteLine("Başlangıç değer bitiş değerinden büyük olamaz");
        }

        private static void Dongu9()
        {

            int j = 0, k = 0;
            int start, end;

            Console.Write("Start : ");
            int.TryParse(Console.ReadLine(), out start);
            Console.Write("End : ");
            int.TryParse(Console.ReadLine(), out end);

            if (start < end)
            {
                for (int i = start; i < end; i++)
                {
                    j++;
                    if (i % 2 == 0)
                        continue;

                    Console.WriteLine(i);
                }

                for (int i = start; i < end; i = i + 2)
                {
                    k++;
                    Console.WriteLine(i);
                }
            }
            else
                Console.WriteLine("Başlangıç değer bitiş değerinden büyük olamaz");
            Console.WriteLine("----");
            Console.WriteLine(j);
            Console.WriteLine("----");
            Console.WriteLine(k);
        }
        private static void Dongu10()
        {
            //Big-O notation

            for (int i = 0; i < 10; i++)
            {
                // 10 defa çalışır O(n) => n=10 olduğunda O(10) karmaşıklık oluşturur.

                Console.WriteLine("i={0}. değer ", i);

                for (int j = 0; j < 10; j++)
                {
                    // Bu j değeri için 
                    // 10 defa çalışır O(n) => n=10 olduğunda O(10) karmaşıklık oluşturur.

                    // Ek olarak dış döngü i için 10 defa çalışan bir yapıdan dolayı limitlerin çarpımı kadar n*m => O(n^2) =>

                    // 100 defa çalışacaktır.
                    Console.WriteLine("\tj={0}. değer ", j);
                }
            }
        }
        private static void Dongu11()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("---{0}. çarpım tablosu---", i);
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} X {1} = {2}", i, j, i * j);
                }
                Console.WriteLine(new string('-', 10));
            }
        }
        private static void Dongu12()
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("---{0}. çarpım tablosu---", i);
                for (int j = 1; j <= 10; j++)
                {
                    int sonuc = i * j;
                    if (sonuc % 7 == 0)
                        break;

                    Console.WriteLine("{0} X {1} = {2}", i, j, sonuc);
                }
                Console.WriteLine(new string('-', 10));

                if (i >= 4)
                    break;
            }

            Console.WriteLine("Çıktım : " + i);
        }
        private static void Dongu13()
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("---{0}. çarpım tablosu---", i);
                for (int j = 1; j <= 10; j++)
                {
                    int sonuc = i * j;
                    if (sonuc % 7 == 0)
                        Console.WriteLine("{0} X {1} = {2}", i, j, sonuc);
                }
                Console.WriteLine(new string('-', 10));
            }

        }
        private static int Dongu14()
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int sonuc = i * j;
                    if (sonuc % 56 == 4)
                        return sonuc;

                }
            }

            return 0;
        }

        private static void Dongu15()
        {
            char yildiz = '*';

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(yildiz);
                }
                Console.WriteLine("");
            }

            //Console.WriteLine("--");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 9; j > i; j--)
                {
                    Console.Write(yildiz);
                }
                Console.WriteLine("");
            }

            //Console.WriteLine("--");

            //for (int i = 0; i < 20; i++)
            //{
            //    int j;
            //    for (j = 0; j < i; j++)
            //    {
            //        Console.Write(yildiz);
            //    }
            //    for (int k = 20; k > 0; k--)
            //    {
            //        Console.Write(yildiz);
            //    }
            //    Console.WriteLine("");
            //}

        }

        private static void Dongu16()
        {
            int i;
            int sayac = 1;
            do
            {
                i = new Random().Next(1, 101);
                Console.WriteLine("{0}. tahmin değeri {1}", sayac, i);
                sayac++;
            } while (i != 59);
        }

        private static void Dongu17()
        {
            int sayac = 1;
            int tahmin;
            int sayi = new Random().Next(1, 51);

            //while (sonuc != tahmin)
            while (true)
            {
                Console.Write("{0}. tahmin : ", sayac);
                int.TryParse(Console.ReadLine(), out tahmin);

                if (sayi == tahmin)
                {
                    Console.WriteLine("Tebrikler {0}. tahminde buldunuz. Sayı:{1}, Tahmin:{2}", sayac, sayi, tahmin);
                    break;
                }

                sayac++;
            }
        }

        static void Ornek1()
        {

            string metin = Console.ReadLine();
            int sayi = 0;

            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == ' ')
                    sayi++;

            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Paragraf " + (sayi + 1) + " kelimeden oluşuyor.");
        }
        static void Ornek2()
        {
            char yildiz = '*';
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sayi; i++)
            {

                for (int j = 0; j < sayi; j++)
                {
                    Console.Write(yildiz);
                }
                Console.WriteLine(" ");

            }

            Console.WriteLine("------------------");



        }
        static void Ornek3()
        {

            int sonuc = 0;
            for (int i = 1; i <= 1000; i++)
            {
                sonuc += i;
            }
            Console.WriteLine("1'den 1000'e kadar olan sayıların toplamı: " + sonuc);


            int sonuc2 = 0;
            for (int j = 500; j <= 2000; j++)
            {
                if (j % 3 == 0)
                    sonuc2 += j;
            }
            Console.WriteLine("500'den 2000'e kadar olan 3'ün katı olan sayıların toplamı: " + sonuc2);

            int sonuc3 = 0;
            for (int k = 20; k <= 80; k++)
            {
                sonuc3 += k * k;
            }
            Console.WriteLine("20'den 80'e kadar olan sayıların karesilerinin toplamı: " + sonuc3);

            int toplam = sonuc + sonuc2 + sonuc3;
            Console.WriteLine("Hepsinin toplamı: " + toplam);
        }
        static void Ornek4()
        {
            int sayi = Convert.ToInt32(Console.ReadLine());
            bool asal = true;

            for (int i = 2; i < sayi - 1; i++)
            {
                if (sayi % i == 0)
                {

                    asal = false;
                    break;
                }

            }
            if (asal)
            {
                Console.WriteLine(sayi + " sayı asaldır");

            }
            else
            {
                Console.WriteLine(sayi + " sayı asal değildir");
            }
            Console.WriteLine("--------------------------");



        }
        static void Ornek5()
        {
            string metin = Console.ReadLine();
            int sayi = 0;

            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == 'a' || metin[i] == 'e' || metin[i] == 'ı' || metin[i] == 'i' || metin[i] == 'o' || metin[i] == 'ö' || metin[i] == 'u' || metin[i] == 'ü' || metin[i] == 'A' || metin[i] == 'E' || metin[i] == 'I' || metin[i] == 'İ' || metin[i] == 'O' || metin[i] == 'Ö' || metin[i] == 'U' || metin[i] == 'Ü')
                    sayi++;
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Paragrafta " + (sayi) + " sesli harf bulunuyor.");

            Console.WriteLine("-----------------");

            string mtn = Console.ReadLine().ToLower();
            int count = 0;
            for (int i = 0; i < mtn.Length; i++)
            {
                if (metin[i] == 'a' || metin[i] == 'e' || metin[i] == 'ı' || metin[i] == 'i' || metin[i] == 'o' || metin[i] == 'ö' || metin[i] == 'u' || metin[i] == 'ü')
                {
                    ++count;
                }
            }
            Console.WriteLine(count + " kadar sesli harf içeriyor.");
        }
        static void Ornek6()
        {


            Random random = new Random();
            int sayi = new Random().Next(1, 100);

            while (true)
            {
                Console.WriteLine("Bir sayı girin: ");
                int tahmin = int.Parse(Console.ReadLine());
                if (sayi == tahmin)
                {
                    Console.WriteLine("DOĞRU");
                    break;
                }

                if (sayi - tahmin >= 5)
                {
                    Console.WriteLine("küçük bir tahminde bulundunuz.");
                }
                if (5 > sayi - tahmin && sayi - tahmin > 0)
                {
                    Console.WriteLine("küçük bir tahminde bulundunuz ama çok yakın");
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                }

                if (tahmin - sayi >= 5)
                {
                    Console.WriteLine("büyük bir tahminde bulundunuz.");
                }
                if (5 > tahmin - sayi && tahmin - sayi > 0)
                {
                    Console.WriteLine("büyük bir tahminde bulundunuz ama çok yakın");
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                }
            }
        }
        static void Ornek7()
        {

            string sayi = new Random().Next(10000, 99999).ToString();

            for (int i = 0; i < sayi.Length; i++)
            {
                Console.WriteLine(sayi[i]);
            }

        }

    }
}
