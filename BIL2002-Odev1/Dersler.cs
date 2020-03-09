using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIL2002_Odev1
{
    class Dersler
    {
        private string ders_kodu;
        private string ders_adi;
        private uint ders_akts;
        private uint ders_not;
        
        public string Ders_kodu
        {
            get
            {
                return ders_kodu;
            }
            set
            {
                ders_kodu = value;
            }
        }
        public string Ders_adi
        {
            get
            {
                return ders_adi;
            }
            set
            {
               ders_adi  = value;
            }
        }
        public uint Ders_akts
        {
             get       
            {
                return ders_akts;
            }
            set
            {
                ders_akts = value;
            }
        }
        public uint Ders_not
        {
                 get
            {
                return ders_not;
            }
            set
            {
                ders_not = value;
            }
        }
    }
}
