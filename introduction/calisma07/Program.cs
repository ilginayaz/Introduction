using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calisma07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { };
            Random random = new Random();



            foreach (var item in arr)
            {
            }
        }

        public static void Print(int[] arr, SıralamaTipi st, SayıTür tür, İşaret x)

        {
            var resultArr = new int[arr.Length];

            if (İşaret.pozitif == x)
            {
                for (int i = 0, j = 0; i < arr.Length; i++)
                {
                    if (x > 0)
                    {
                        resultArr[j] = arr[i];
                        ++j;
                    }
                }
            }
            else
            {
                for (int i = 0, j = 0; i < arr.Length; i++)
                {
                    if (x < 0)
                    {
                        resultArr[j] = arr[i];
                        ++j;
                    }
                }

            }

            var resultArr2 = new int[arr.Length];

            for (int i = 0, j = 0; i < resultArr2.Length; i++)
            {


            }
        }



    }

    public enum SıralamaTipi : int
    {
        artan = 1,
        azalan = 2


    }
    public enum SayıTür : int
    {
        çift = 1,
        tek = 2
    }
    public enum İşaret : int
    {
        pozitif = 1,
        negatif = 2
    }


}