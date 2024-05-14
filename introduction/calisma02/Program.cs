using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calisma02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ornek1();
            //Ornek2();

            Sure();


            //int[,] array = new int[6, 6];
            //Random random = new Random();

            //for (int i = 0; i<6; i++)
            //{

            //    for (int j = 0; j<6; j++)
            //    {

            //        array[i, j] = random.Next(1,20);
            //        Console.Write(array[i,j]+" ");
            //    }
            //    Console.WriteLine();
            //}



        }

        private static void Ornek1()
        {


            Console.WriteLine("Menü girişi yapın: ");

            bool kontrol = true;


            int toplam = 0;

            while (kontrol)
            {
                string siparis = Console.ReadLine();

                switch (siparis)
                {
                    case "menu 1":


                        toplam += 500;

                        break;

                    case "menu 2":
                        toplam += 1500;

                        break;

                    case "menu 3":
                        toplam += 2500;

                        break;
                    case "menu 4":
                        toplam += 3500;

                        break;
                    case "menu 5":
                        toplam += 4000;

                        break;

                    case "exit":
                        kontrol = false;
                        break;

                    default:
                        Console.WriteLine("hatalı giriş.");
                        break;




                }
            }

            Console.WriteLine("Aldıgınız toplam kalori= " + toplam);
        }
        private static void Ornek2()
        {
            string sifre = "1a2c";


            char[] array = { 'a', 'b', 'c', 'd', '1', '2', '3' };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    for (int k = 0; k < array.Length; k++)
                    {
                        for (int l = 0; l < array.Length; l++)
                        {
                            var temp = array[i].ToString() + array[j].ToString() + array[k].ToString() + array[l].ToString();

                            if (temp == sifre)
                            {
                                Console.WriteLine("Sifre: " + temp);
                                break;
                            }
                        }
                    }
                }
            }


        }

        //public static int[] Büyüt(int[] arr)
        //{

        //    //main
        //    int[] testArr = new int[3] { 1, 2, 3 };

        //    Console.WriteLine("ilk");
        //    foreach (int i in testArr)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    Console.WriteLine();

        //    var result = Büyüt(testArr);







        //    int[] newArr = new int[arr.Length+1];

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        newArr = arr[i];
        //    }
        //    return newArr;
        //}

        public static void Sure()
        {


            Random random = new Random();
            int sayi = random.Next(1, 15);
            Console.WriteLine(sayi);

            Console.WriteLine(sayi + " saniyede tusuna basın");
            var first = DateTime.Now;

            var dum = Console.ReadLine();

            var second = DateTime.Now;

            var result = second - first;

            var result1 = (int)result.TotalSeconds;

            Console.WriteLine("hedef süre " + sayi);

            Console.WriteLine("siz " + result + " saniye kadar sonra islem yaptınız");

            //if (result == sayi)
            //{
            //    Console.WriteLine("kazandınız");
            //}
            //else
            //{
            //    Console.WriteLine("kaybettiniz");
            //}




            //string tus = Console.ReadLine();



            //DateTime time = DateTime.Now;
            //DateTime timeSecond = DateTime.Now.AddMinutes(10);
            //var result = timeSecond - time;
            //Console.WriteLine((int)result.TotalSeconds);

        }

    }


}