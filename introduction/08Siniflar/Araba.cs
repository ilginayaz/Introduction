using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    //[erişim_belirleyici] class [sinif_adi]
    public class Araba
    {
        //Sınıf üyeleri
        /*
         * sınıf için değişken field diye bilinir.
         * [erişim_belirleyici] [veri_tipi] [değişken_adi] = [varsa_ilk_değer];
         * 
         * sınıf için özellik property diye bilinir.
         * [erişim_belirleyici] [veri_tipi] [Property_adi] { get; set; }
         * 
         * sınıf için fonksiyon metot diye bilinir.
         * [erişim_belirleyici] [dönüş_tipi] [Metoto_adi]([varsa_parametreler{veri_tip değişken_adi}]) {}
         * 
         * sınıf için Yapıcı ve Yıkıcı Metotlar Construction ve Deconstruction
         * 
         * 
         */

        private string _marka_field;

        public string marka;
        public string model;
        public short yil;
        public bool otomatikMi;
        public byte yakitTipi;

        public Araba()
        {
            //Console.WriteLine("Yapıcı metot olarak ben ilk çalıştım.");
            yil = 2000;
            otomatikMi = true;
            yakitTipi = 3;
            marka = "Boş";
            model = "Boş";

        }

        public Araba(string _marka, string _model, short yil, bool _otomatikMi, byte _yakiTipi)
        {
            //Console.WriteLine("Yapıcı metot olarak ben ilk çalıştım.");
            this.yil = yil;
            otomatikMi = _otomatikMi;
            yakitTipi = _yakiTipi;
            marka = _marka;
            model = _model;

        }

        //public string Marka { get; set; }

        public string Marka
        {
            get
            {
                //return "Tofaş Şahin";
                return _marka_field.ToUpper();
            }

            set
            {
                _marka_field = value;
            }
        }

        public short Devir { get; set; }

        //public string GetMarka()
        //{
        //    return _marka_field;
        //}

        //public void SetMarka(string marka)
        //{ 
        //    _marka_field = marka;
        //}


        public string OrtalamaYakitTuketimi()
        {
            string ortYakitTuketimi = "";


            if (Devir >= 1200 && this.Devir < 1750)
            {
                ortYakitTuketimi = "4.5 Litre / 100 Km";
            }
            else if (this.Devir >= 1750 && this.Devir < 2750)
            {
                ortYakitTuketimi = "4.9 Litre / 100 Km";
            }
            else if (this.Devir >= 2750)
            {
                ortYakitTuketimi = "5.3 Litre / 100 Km";
            }
            else
            {
                ortYakitTuketimi = "0.0 Litre / 100 Km";
            }

            return ortYakitTuketimi;
        }

        public override string ToString()
        {
            string vites = this.otomatikMi ? "Otomatik Vites" : "Düz Vites";
            string yakit = this.yakitTipi == 1 ? "Benzinli" : "Dizsel";

            string araba = string.Format("Marka:{0}\nModel:{1}\nYıl:{2}\nVites:{3}\nYakıt:{4}\n",
                                        this.marka, this.model, this.yil, vites, yakit);

            return araba;
        }

        ~Araba()
        {
            Console.WriteLine("İlgili sınıf objesi ramden kaldırıldı.");
        }

    }
}