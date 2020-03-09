using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIL2002_Odev1
{
    class Ogrenci:Dersler
    {
        private uint ogr_num;
        private string ogr_ad_soyad;
        private string ogr_bolum_adi;
        public uint Ogr_num
        {
            get 
            {
                return ogr_num;
            }
            set
            {
                ogr_num = value;
            }
        }

        public string Ogr_ad_soyad
        {
            get
            {
                return ogr_ad_soyad;
            }
            set
            {
                ogr_ad_soyad = value;
            }

        }
        public string Ogr_bolum_adi
        {
            get
            {
                return ogr_bolum_adi;
            }
            set
            {
                ogr_bolum_adi = value;
            }
        }

        
    }
}
