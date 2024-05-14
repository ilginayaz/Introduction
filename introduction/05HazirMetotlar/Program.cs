using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05HazirMetotlar
{
    internal class Program
    {

        // [Erişim_Belirleyici](public,private,protected,internal) [Davranış_Belirleyici](staic,virtual,abstract)
        // [Geri_Dönüş_Belirleyicisi](void,ilkel veri tipleri,Kullanıcı Tanımlı Veri Tipleri)
        // [Metot_Adi](Değişken adı kuralları geçerli)
        // ([Parametre_tipi] [Parametre_Adi])


        //static readonly string a;
        //readonly string b = "aaa";
        //const string s = "Merhaba ben bir sabitim";

        //public Program()
        //{
        //    b = "Yeni bir değer";
        //}


        static void Main(string[] args)
        {
            //Console.WriteLine("ABCDEFGHIJKLMNOPRSTUVYZ");

            //SayHello();
            //Add();
            //Screen();

            //var sonuc = RandomNumberSum();
            //Console.WriteLine(sonuc);

            //var @char = Console.ReadKey();
            //Console.WriteLine("");
            //Console.WriteLine(@char.KeyChar);
            //Console.WriteLine(@char.Key);


            //Console.WriteLine(s);
            //Console.WriteLine(a);


            //StringMetotlar();
            //MathMetotlar();
            //DateMetotlar();
            //CharMetotlar();

            //Ornek1();
            //Ornek2();
            //Ornek3();
            //Ornek4();

            Console.ReadLine();
        }
        private static void StringMetotlar()
        {
            string metin = "Bu bir STRİNG ifadedir.";

            //metin.ToLower(); // bütün karakterleri küçük hafr olarak değiştirir.

            Console.WriteLine("ToLower() : {0} , Orjinal : {1}", metin.ToLower(), metin); // bütün karakterler küçük hafr olur.
            Console.WriteLine("ToUpper() : {0} , Orjinal : {1}", metin.ToUpper(), metin); // BÜTÜN KARAKTERLER BÜYÜK HARF OLUR.

            Console.WriteLine("Length : {0} , Orjinal : {1}", metin.Length, metin); // string ifadenin uzunluğunu verir.

            Console.WriteLine("StartsWith : {0} , Orjinal : {1}", metin.StartsWith("Şu"), metin); // string ifadenin ilk başlangıç ifadesine bool
            Console.WriteLine("StartsWith : {0} , Orjinal : {1}", metin.StartsWith("Bu"), metin); // string ifadenin ilk başlangıç ifadesine bool
            Console.WriteLine("StartsWith : {0} , Orjinal : {1}", metin.StartsWith("Ş"), metin); // string ifadenin ilk başlangıç ifadesine bool
            Console.WriteLine("StartsWith : {0} , Orjinal : {1}", metin.StartsWith("b"), metin); // string ifadenin ilk başlangıç ifadesine bool
            Console.WriteLine("StartsWith : {0} , Orjinal : {1}", metin.StartsWith("b", StringComparison.OrdinalIgnoreCase), metin); // string ifadenin ilk başlangıç ifadesine bool

            // StringComparison.OrdinalIgnoreCase bu ifade ile büyük küçük duyarlılığı iptal etmiş oluyoruz.

            Console.WriteLine("EndsWith : {0} , Orjinal : {1}", metin.EndsWith("b"), metin); // string ifadenin son karakter ifadesine bool
            Console.WriteLine("EndsWith : {0} , Orjinal : {1}", metin.EndsWith("."), metin); // string ifadenin son karakter  ifadesine bool
            Console.WriteLine("EndsWith : {0} , Orjinal : {1}", metin.EndsWith("ifadedir."), metin); // string ifadenin son karakter  ifadesine bool

            //Console.WriteLine("Normalize : {0} , Orjinal : {1}", metin.ToLower().Normalize(), metin); // ilgili metin 

            Console.WriteLine("Contains : {0} , Orjinal : {1}", metin.Contains("bir string"), metin); // string ifadenin içinde ilgili aranan değer var mı

            // Console.WriteLine("Contains : {0} , Orjinal : {1}", metin.Contains("bir string", StringComparison.CurrentCultureIgnoreCase), metin); // string ifadenin içinde ilgili aranan değer var mı?

            // PadRight(5), PadLeft(5) 
            // Metot içinde ki sayısal ifade ilgili metnin karakter sayısından fazla ise bir işlem yapmaz
            // Eğer metinsel ifadenin uzunluğu metot içinde değerden az ise toplamda değer kadar olacak kalan kısımlarını sağdan yada soldan
            // boşluk ekeler.
            // Ör:
            // "Bu".PadRight(5) çıktı için => sağ tarafa 3 birim boşluk atar. "Bu   "
            // "Bu".PadLeft(5) çıktı için => sol tarafa 3 birim boşluk atar. "   Bu"

            Console.Write("Bu".PadRight(5));
            Console.WriteLine("Test");
            Console.WriteLine("Bu".PadLeft(5));

            Console.WriteLine("-------");

            Console.WriteLine("Replace : {0} , Orjinal : {1}", metin.Replace('B', 'Ş'), metin);
            //Console.WriteLine("Replace : {0} , Orjinal : {1}", metin.Replace("B", "Ş"), metin);
            //Console.WriteLine("Replace : {0} , Orjinal : {1}", metin.Replace("B", "Ş", StringComparison.OrdinalIgnoreCase), metin);
            Console.WriteLine("Replace : {0} , Orjinal : {1}", "Bu Bir Bugün Benim Belirlediğim Bir Betik".Replace("B", "Ş"), "Bu Bir Bugün Benim Belirlediğim Bir Betik");


            var donus = "http://www.google.com".Split('.');

            for (int i = 0; i < donus.Length; i++)
            {
                Console.WriteLine(donus[i]);
            }

            var yeniMetin = "Merhaba||Dünya,Bugün||haftanın ortanca||günü".Split('a');

            for (int i = 0; i < yeniMetin.Length; i++)
            {
                Console.WriteLine(yeniMetin[i]);
            }

            var words = "Merhaba||Dünya,Bugün||haftanın ortanca||günü".Split();


            Console.WriteLine("Bugünlerde hava çok soğudu. Sıkı giyinelim. Hasta olmayalım.".Substring(10));
            Console.WriteLine("Bugünlerde hava çok soğudu. Sıkı giyinelim. Hasta olmayalım.".Substring(10, 11));

            Console.WriteLine("Bugünlerde hava çok soğudu. Sıkı giyinelim. Hasta olmayalım.".IndexOf('a'));
            Console.WriteLine("Bugünlerde hava çok soğudu. Sıkı giyinelim. Hasta olmayalım.".IndexOf('a', 20));
            Console.WriteLine("Bugünlerde hava çok soğudu. Sıkı giyinelim. Hasta olmayalım.".IndexOf("av"));
            Console.WriteLine("Bugünlerde hava çok soğudu. Sıkı giyinelim. Hasta olmayalım.".IndexOf("as"));
            Console.WriteLine("Bugünlerde hava çok soğudu. Sıkı giyinelim. Hasta olmayalım.".IndexOf("Hasta"));

        }


        private static void MathMetotlar()
        {
            Console.WriteLine(Math.E);
            Console.WriteLine(Math.PI);

            Console.WriteLine("---");

            Console.WriteLine(Math.Abs(-5));
            Console.WriteLine(Math.Abs(-5.9));
            Console.WriteLine(Math.Abs(-5.7f));
            Console.WriteLine(Math.Abs(-5.68m));

            Console.WriteLine("---");

            Console.WriteLine(Math.Ceiling(12.1));
            Console.WriteLine(Math.Floor(12.9));
            Console.WriteLine(Math.Round(12.6));
            Console.WriteLine(Math.Round(12.51));
            Console.WriteLine(Math.Round(12.3));
            Console.WriteLine(Math.Round(12.346, 2));
            Console.WriteLine("---");
            Console.WriteLine(Math.Exp(2));
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Sqrt(12));

            // Matematik kütüphanesinde ki Trigonometri işlemleri için alınan değer Radyandır.

            Console.WriteLine(Math.Sin((90 * Math.PI) / 180)); // (90*Math.PI)/180) radyan to degreee

        }

        private static void DateMetotlar()
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.UtcNow);

            Console.WriteLine("----");

            DateTime dt = new DateTime();

            Console.WriteLine(dt);

            Console.WriteLine("----");

            dt = new DateTime(2020, 10, 23);

            Console.WriteLine(dt);

            dt = new DateTime(2020, 10, 23, 12, 45, 38);

            Console.WriteLine(dt);

            Console.WriteLine("----------------");

            Console.WriteLine(dt.Date);
            Console.WriteLine(dt.Day);
            Console.WriteLine(dt.Month);
            Console.WriteLine(dt.Year);
            Console.WriteLine(dt.Hour);
            Console.WriteLine(dt.Minute);
            Console.WriteLine(dt.Second);

            Console.WriteLine(DateTime.Now.Millisecond);


            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.AddDays(5));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(5));
            Console.WriteLine(DateTime.Now.AddHours(5));
            Console.WriteLine(DateTime.Now.AddMinutes(5));
            Console.WriteLine(DateTime.Now.AddSeconds(5));

            Console.WriteLine(DateTime.Now.AddDays(-5));
            Console.WriteLine(DateTime.Now.AddMonths(-5));
            Console.WriteLine(DateTime.Now.AddYears(-5));
            Console.WriteLine(DateTime.Now.AddHours(-5));
            Console.WriteLine(DateTime.Now.AddMinutes(-5));
            Console.WriteLine(DateTime.Now.AddSeconds(-5));

            Console.WriteLine(dt.DayOfWeek);
            Console.WriteLine(dt.DayOfYear);
            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine(dt.ToString());
            Console.WriteLine(dt.ToLongDateString());
            Console.WriteLine(dt.ToShortDateString());
            Console.WriteLine(dt.ToLongTimeString());
            Console.WriteLine(dt.ToShortTimeString());
        }

        private static void CharMetotlar()
        {
            //Console.WriteLine(char.Parse("Metin")); Parse exception atar
            Console.WriteLine(char.Parse("M"));
            Console.WriteLine(char.IsDigit('5'));
            Console.WriteLine(char.IsDigit('A'));
            Console.WriteLine(char.IsLower('a'));
            Console.WriteLine(char.IsLower('A'));
            Console.WriteLine(char.IsUpper('A'));
            Console.WriteLine(char.IsUpper('a'));
            Console.WriteLine(char.IsLetter('A'));
            Console.WriteLine(char.IsLetter('0'));
        }
        public static void Add()
        {
            Console.WriteLine("Fonksiyon çalışmaya başladı.");
            int i = 5;
            int j = 10;
            Console.WriteLine("Değişkenler tanımlandı...");
            int result = i * j;
            Console.WriteLine("Gerekli iş plan çalıştırıldı...");
            //MyService.Add(result);

            Console.WriteLine("İlgili servise ilgili değer gönderildi.");
        }

        public static int RandomNumberSum()
        {
            int a = new Random().Next(1, 101);
            int b = new Random().Next(1, 101);

            int sonuc = a + b;

            return sonuc;

            //return a + b;
        }

        public static void Screen()
        {
            while (true)
            {
                Console.WriteLine("Random Numbers Sum : " + RandomNumberSum());
                var karakter = Console.ReadKey(true);

                while (karakter.Key != ConsoleKey.Enter && karakter.Key != ConsoleKey.Escape)
                {
                    //Tuş yanlış tekrar isteyeceğiz
                    karakter = Console.ReadKey(true);
                }

                if (karakter.Key == ConsoleKey.Enter)
                    continue;
                if (karakter.Key == ConsoleKey.Escape)
                    break;
            }
        }

       /* private static void Ornek1()
        {
            Random random = new Random();

            var randomNumber = random.NextInt64(1000000000, 9999999999);

            var str = random.ToString();
            Console.WriteLine(str);
            var maxChar = ' ';
            var max = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '*')
                {
                    continue;
                }
                var tempMax = 0;
                var search = str[i];

                for (int j = 0; j < str.Length; i++)
                {
                    if (str[i] == search)
                    {
                        ++tempMax;
                    }

                }

                if (tempMax > max)
                {
                    max = tempMax;
                    maxChar = search;
                }

                str = str.Replace(search, '*');


            }
            Console.WriteLine("sayısı: " + max);
            Console.WriteLine("en cok tekrar eden sayı: " + maxChar.ToString());

        }
       */
        private static void Ornek2()
        {

            string metin = Console.ReadLine();

            var maxChar = ' ';
            var max = 0;
            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == '*')
                {
                    continue;
                }
                var tempMax = 0;
                var search = metin[i];

                for (int j = 0; j < metin.Length; j++)
                {
                    if (metin[j] == search)
                    {
                        ++tempMax;
                    }
                }

                if (tempMax > max)
                {
                    max = tempMax;
                    maxChar = search;
                }
                metin = metin.Replace(search, '*');
            }

            Console.WriteLine("sayısı: " + max);
            Console.WriteLine("en cok tekrar eden sayı: " + maxChar);
        }
        private static void Ornek3()
        {
            Console.WriteLine("bir sifre girin:");
            var sifre = Console.ReadLine();

            int buyukSayi = 0;
            int kucukSayi = 0;
            int sayiAdet = 0;
            int alfaNum = 0;
            bool sifre1 = sifre.Length >= 12;


            for (int i = 0; i < sifre.Length; i++)
            {

                if (char.IsUpper(sifre[i])) ++buyukSayi;

                if (char.IsLower(sifre[i])) ++kucukSayi;

                if (char.IsLetter(sifre[i])) ++sayiAdet;

                if (!char.IsLetterOrDigit(sifre[i])) ++alfaNum;

            }


            if (buyukSayi < 2)
            {
                Console.WriteLine("Sifre en az 2 adet büyük harf içermelidir.");
            }
            if (kucukSayi < 2)
            {
                Console.WriteLine("Sifre en az 2 adet küçük harf içermelidir.");

            }
            if (sayiAdet < 2)
            {
                Console.WriteLine("Sifre en az 2 adet sayı içermelidir.");

            }
            if (alfaNum < 2)
            {
                Console.WriteLine("Sifre en az 2 adetkarakter içermelidir.");

            }
            if (!sifre1)
            {
                Console.WriteLine("Sifre en az 12 karakter içermelidir.");

            }

            bool status = sifre1 && buyukSayi >= 2 && kucukSayi >= 2 && sayiAdet >= 2 && alfaNum >= 2;

            status = !status;
            if (!status)
            {
                Console.WriteLine("ŞİFRE KABUL EDİLDİ");
            }
            else
            {
                Console.WriteLine("şifre kabul edilmedi, başarısız.");
                Console.WriteLine("tekrar şifre girme alanına gönderiliyorsunuz.");
            }
        }
        private static void Ornek4()
        {

            string metin = Console.ReadLine();
            var kelime = metin.Split(' ');
            var maxString = " ";
            var max = 0;

            for (int i = 0; i < kelime.Length; i++)
            {

                var tempMax = 0;
                var search = kelime[i];

                for (int j = 0; j < kelime.Length; j++)
                {

                    if (kelime[i] == "*")
                    {
                        continue;
                    }
                    if (kelime[j] == search)
                    {
                        kelime[j] = "*";

                        ++tempMax;
                    }
                }

                if (tempMax >= max)
                {
                    max = tempMax;
                    maxString = search;
                }

            }

            Console.WriteLine("sayısı: " + max);
            Console.WriteLine("en cok tekrar eden kelime: " + maxString);
        }

    }
}
