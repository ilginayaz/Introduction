using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hata Yonetimi");

            //HataYonetimi();
            //HataYonetimi1ek();
            //HataYonetimi2();
            //HataYonetimi3();
            //HataYonetimi4();
            //Ornekler1();
            //Ornekler2();
            //Ornekler3();
            //Ornekler4();

            Console.ReadKey();
        }
        static void HataYonetimi()
        {
            // int sayi = 10/0; //derleme zamanı (compiling time) hatası

            int sayi1 = 10;
            int sayi2 = 0;

            int sonuc = sayi1 / sayi2; //calısma zamanı (runtime) hatası

            byte deger = 125;

            if (deger >= 0)
            {
                Console.WriteLine("değer 0a eşit veya büyüktür");
            }
            else
            {
                Console.WriteLine("değer 0dan kücüktür");
            }

            if (2 > 1)
            {
                Console.WriteLine("değer 0a eşit veya büyüktür");
            }
            else
            {
                Console.WriteLine("değer 0dan kücüktür");
            }
        }
        static void HataYonetimi1ek()

        {
        A:
            Console.WriteLine("Sayı 1:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı 2:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            /* 
            Console.WriteLine("Merhaba program {0}. kez çalıştı.", i);
             int sonuc = sayi1/ sayi2; // Burada oluşacak hata Çalışma Zamanı (Runtime) hatası

             if ( sonuc < 10 )
             {
                 i++;

                 goto A;
             }
            */
        }
        static void HataYonetimi2()
        {
        B:
            Console.Write("Sayı 1:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı 2:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                //Hata olması muhtemel kod bloğu

                int sonuc = sayi1 / sayi2; // Burada oluşacak hata Çalışma Zamanı (Runtime) hatası
                Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, sonuc); 
            }
            catch (Exception ex) // Genel Hata yakalama sınıfı Exception
            {
                //Hata olduğunda çalışacak kod bloğu
                Console.WriteLine(ex.Message);
            }

            goto B;

        }

        static void HataYonetimi3()
        {
        B:
            try
            {
                Console.Write("Sayı 1:");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Sayı 2:");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                //Hata olması muhtemel kod bloğu

                int sonuc = sayi1 / sayi2; // Burada oluşacak hata Çalışma Zamanı (Runtime) hatası
                Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, sonuc); 
            }
            catch (DivideByZeroException ex)
            {
                //Hata olduğunda çalışacak kod bloğu
                Console.WriteLine("DivideByZero Exc:" + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format Exc:" + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Overflow Exc:" + ex.Message);
            }
            catch (Exception ex)
            {
                //Hata olduğunda çalışacak kod bloğu
                Console.WriteLine("Exception :" + ex.Message);
            }

            goto B;


        }

        static int HataYonetimi4()
        {
            int sonuc;

            string mesaj = "";

            try
            {
                Console.Write("Sayı 1:");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Sayı 2:");
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                //Hata olması muhtemel kod bloğu

                sonuc = sayi1 / sayi2; // Burada oluşacak hata Çalışma Zamanı (Runtime) hatası
                Console.WriteLine("{0} / {1} = {2}", sayi1, sayi2, sonuc); 

                return sonuc;
            }
            catch (DivideByZeroException ex)
            {
                //Hata olduğunda çalışacak kod bloğu
                //Console.WriteLine("DivideByZero Exc:" + ex.Message);
                mesaj = ex.Message;
                return 0;
            }
            catch (FormatException ex)
            {
                //Console.WriteLine("Format Exc:" + ex.Message);
                mesaj = ex.Message;
                return 0;
            }
            catch (OverflowException ex)
            {
                //Console.WriteLine("Overflow Exc:" + ex.Message);
                mesaj = ex.Message;
                return 0;
            }
            catch (Exception ex)
            {
                //Hata olduğunda çalışacak kod bloğu
                //Console.WriteLine("Exception :" + ex.Message);
                mesaj = ex.Message;
                return 0;
            }
            finally
            {
                Console.WriteLine("Son blok log yazdım bir yere haber verdim. Ancak kimse beni duymuyor. Ex:" + mesaj);
            }
        }


        static void Ornekler1()
        {
            try
            {
                var number = int.Parse(Console.ReadLine());

                Console.WriteLine((number * 4));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("sıfıra bölünme hatası");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("dizi sınırı aşma hatası");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Data);
                Console.WriteLine(e.HResult);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.HelpLink);
                Console.WriteLine("hatalı bir veri girişi yaptınız");
            }
        }
        static void Ornekler2()
        {
            //Ogrenci not hesaplama, ögrenciden değişken sayıda not alalım sonra bu değişken sayıdaki notun toplamıonı kaça böleceğimizi isteyelim en son bu bölümün cevanı yazdıralım

            Console.WriteLine("Kac adet not girecegini yazın :");
            int count = int.Parse(Console.ReadLine());
            int sum = 0;

            while (0 < count)
            {
                --count;
                try
                {
                    Console.WriteLine((count + 1) + " .veriyi giriniz :");
                    sum = +int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("hatalı bir veri girişi yaptınız.");
                    ++count;
                }

            }

            bool control = true;
            while (control)
            {
                Console.WriteLine("toplamı kaca böleceksiniz");
                int bolum = int.Parse(Console.ReadLine());
                try
                {
                    Console.WriteLine(sum / bolum);
                    control = false;
                }
                catch (DivideByZeroException)
                {
                    control = true;
                    Console.WriteLine("sıfırdan farklı bir deger girin");
                }
            }

        }
        static void Ornekler3()
        {


            Console.WriteLine("Parkur uzunluğunu metre cinsinden yazın: ");

            bool control = true;
            int metre = 0;
            while (control)
            {
                try
                {
                    metre = int.Parse(Console.ReadLine());
                    if (metre > 0)
                    {
                        control = false;
                    }
                    else
                    {
                        Console.WriteLine("Sıfırdan büyük bir sayı girin.");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Geçersiz bir sayı girişinde bulundunuz.");
                }
            }



            Console.WriteLine("Kaç tur koştuğunuzu yazın: ");
            double tur = 0;
            while (control)
            {
                try
                {
                    tur = int.Parse(Console.ReadLine());
                    if (tur > 0)
                    {
                        control = false;
                    }
                    else
                    {
                        Console.WriteLine("Sıfırdan büyük bir sayı girin.");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Geçersiz bir sayı girişinde bulundunuz.");
                }
            }

            double km = (metre * tur) / 1000;
            Console.WriteLine(km + " km koştunuz.");

            Console.WriteLine("Kaç dakika koştuğunuzu yazın: ");
            int dakika = int.Parse(Console.ReadLine());


            double saat = dakika / 60.0;
            double hiz = km / saat;
            Console.WriteLine("Ortalama hızınız: " + hiz);

        }
        static void Ornekler4()
        {

            string srt = "ilgin123test";
            int i = 0;
            int toplam = 0;
            while (srt.Length > i)
            {
                i++;
                try
                {
                    toplam += int.Parse(srt[i].ToString());

                }
                catch (Exception)
                {


                }
                Console.WriteLine(toplam);
            }

        }
    }
}
