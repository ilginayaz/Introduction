using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calisma04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] yildiz = new string[3, 3];
            int i = 0;

            for (i = 0; i < yildiz.Length; i++)
            {
                for (int j = 0; j < yildiz.GetLength(1); j++)
                {
                    yildiz[i, j] = "*";
                    Console.WriteLine(yildiz[i, j] + " ");
                }
                Console.WriteLine();
            }
            i = 0;

            while (i < 9)
            {
                var kulKoor = Console.ReadLine();
                var xK = int.Parse(kulKoor.Split(',')[0]);
                var yK = int.Parse(kulKoor.Split(',')[1]);
                yildiz[xK, yK] = "0";
                ++i;

                var control = true;
                Random rndm = new Random();
                while (control)
                {
                    var cX = rndm.Next(0, 3);
                    var cY = rndm.Next(0, 3);

                    if (yildiz[cX, cY] == "*")
                    {

                    }
                }

            }

        }
    }
}