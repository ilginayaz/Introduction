using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace calisma03
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }

        private static bool SifreAl()
        {

            Console.WriteLine("Lütfen şifre girin: ");

            int sifre = 1234;



            for (int i = 0; i < 3; i++)
            {

                int giris = int.Parse(Console.ReadLine());
                if (sifre == giris)
                {
                    Console.WriteLine("Şifre doğru");
                    return true;

                }

                else
                {
                    Console.WriteLine("Şİfre yanlış, tekrar deneyin.");
                }

            }
            Console.WriteLine("3 kere hatalı giriş yaptınız.");
            return false;


        }
        private static void ParaCek()
        {
            int bakiye = 2500;
            Console.WriteLine("Bakiyeniz: " + bakiye);
            Console.WriteLine("Çekilecek miktarı girin: ");
            int paraC = int.Parse(Console.ReadLine());

            while (true)
            {
                if (paraC <= bakiye)
                {
                    Console.WriteLine("Kalan bakiye= " + (bakiye - paraC));
                    break;

                }

                else
                {
                    Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır. Tekrar girin: ");
                    paraC = int.Parse(Console.ReadLine());

                }

            }
        }
        private static void ParaEkle()
        {
            int bakiye = 2500;
            Console.WriteLine("Bakiyeniz: " + bakiye);
            Console.WriteLine("Eklenecek miktarı girin: ");
            int paraE = int.Parse(Console.ReadLine());

            if (paraE % 10 == 0)
            {
                int toplam = bakiye + paraE;
                Console.WriteLine("Yeni bakiyeniz: " + toplam);

            }

            else
            {
                Console.WriteLine("Geçersiz veri girişinde bulundunuz. Yeniden deneyin.");


            }

        }
        private static void ParaGOnder()
        {

        }

    }
}