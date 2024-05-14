using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calisma05
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class OyunKaset
    {

        private int süre;

        public string OyunAdi { get; set; }
        public int ToplamSureDakika
        {
            get;
            set;
        }
        private DateTime First;
        private DateTime Second
            ;
        public void Basla()
        {
            First = DateTime.Now;
        }
        public void Bitir()
        {
            var time = DateTime.Now - First;
            ToplamSureDakika += (int)time.TotalMinutes;
        }

    }

    public class Atari
    {
        public OyunKaset[] Oyunlar { get; set; }




        public void OyunAra(string ad)
        {
            foreach (var item in Oyunlar)
            {
                if (item.OyunAdi == ad)
                {
                    Console.WriteLine(" oyun adı " + ad);
                }
            }
        }

        public void OyunBasla(string s)
        {

        }

        public void OyunBitir(string s)
        {

        }


    }
}

