using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calisma01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ornek1();
            //Ornek2();


        }


        private void Ornek1()
        {
            Random random = new Random();

            Console.WriteLine("Rastgele 6 sayı:");

            for (int i = 0; i < 6; i++)
            {
                int randomNumber = random.Next(1, 51);
                Console.Write(randomNumber + " ");
            }

            Console.ReadLine();
        }

        private void Ornek2()
        {
            int toplam = 0;

            for (int i = 1; i <= 10; i++)
            {
                toplam += i;
            }

            Console.WriteLine("1'den 10'a kadar olan tam sayıların toplamı: " + toplam);

            Console.ReadLine();

            Console.WriteLine("----------------------------");

            
            int sayi = 1;

            while (sayi <= 10)
            {
                toplam += sayi;
                sayi++;
            }

            Console.WriteLine("1'den 10'a kadar olan tam sayıların toplamı: " + toplam);

            Console.ReadLine();
        }
    }
}