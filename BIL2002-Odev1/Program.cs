using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIL2002_Odev1;
namespace BIL2002_Odev1
{
    class Program
    {
           
           static void Main(string[] args)
           {
           Start:
               
               Console.WriteLine("0. Anasayfa");
               Console.WriteLine("1. Bilgi  Girişi");
               Console.WriteLine("2. Bilgileri Ekrana Göster");
               Console.WriteLine("3. Çıkış");
               //Lisans a = new Lisans();
               //a.Ogr_ad_soyad = "Ali";
               //a.Ogr_bolum_adi = "MATHEMATICS";
               //a.Ogr_num = 2015280059;
               //a.Ders_adi = "Bilişim";
               //a.Ders_kodu = "Mat200";

               //a.Ders_akts = 5;
               //a.Ders_not = 92;


               switch (Convert.ToInt16(Console.ReadLine()))
               {

                   case 0:
                       //anasayfa
                       Console.WriteLine("0. Anasayfa");
                       Console.WriteLine("1. Bilgi  Girişi");
                       Console.WriteLine("2. Bilgileri Ekrana Göster");
                       Console.WriteLine("3. Çıkış");
                       break;
                   case 1:
                       //bilgi girişi yapılıyor
                       Console.WriteLine("Lütfen sırasıyla bilgileri giriniz\n");
                       Console.WriteLine("1. Lisans");
                       Console.WriteLine("2. Yüksek Lisans");
                       Console.WriteLine("3. Doktora");
                       switch (Convert.ToInt16(Console.ReadLine()))
                       {
                           case 1:
                               //Lisans öğrencisi seçimi
                               Lisans a = new Lisans();

                               Console.WriteLine("Öğrenci Numara: "); a.Ogr_num = Convert.ToUInt32(Console.ReadLine());
                               Console.WriteLine("\nÖğrenci Ad Soyad: "); a.Ogr_ad_soyad = Console.ReadLine();
                               Console.WriteLine("\nÖğrenci Bölüm: "); a.Ogr_bolum_adi = Console.ReadLine();
                               //Console.WriteLine("\nÖğrenci kaç ders alıyor? ");
                               //int i;
                               //for ( i = 0; i <Convert.ToInt16 (Console.ReadLine()); i++)
                               // {
                               //     Console.WriteLine("\nDers Kodu: "); a.Ders_kodu = Console.ReadLine();
                               //     Console.WriteLine("\nDers Adı: "); a.Ders_adi = Console.ReadLine();
                               //     Console.WriteLine("\nDers Akts: "); a.Ders_akts = Convert.ToUInt32(Console.ReadLine());
                               //     Console.WriteLine("\nDers Not: "); a.Ders_not = Convert.ToUInt32(Console.ReadLine());
                                   
                               // } 
                               goto Start;
                               
                               break;
                           case 2:
                               //Yüksek Lisans ögrencisi seçimi
                               break;
                           case 3:
                               //Doktora ögrencisi seçimi
                               break;
                       }

                       Console.WriteLine("Lütfen sırasıyla bilgileri giriniz\n");
                       Console.WriteLine("Ogrenci Numarası:"); Console.ReadLine();

                       goto case 0;
                       break;
                   case 2:
                       //bilgiler ekrana geliyor
                       Console.WriteLine("LISANS\n");
                         
                       //Console.WriteLine("\t" + a.Ogr_num + ";\t" + a.Ogr_ad_soyad + ";\t" + a.Ogr_bolum_adi);
                       //Console.WriteLine("\n\t" + a.Ders_kodu + ";\t" + a.Ders_adi + ";\t" + a.Ders_akts+" akts;\t"+a.Ders_not);
                       goto case 0;
                       break;
                   case 3:
                       Environment.Exit(0);

                       break;
                   default:
                       Console.WriteLine("0. Anasayfa");
                       Console.WriteLine("1. Bilgi  Girişi");
                       Console.WriteLine("2. Bilgileri Ekrana Göster");
                       Console.WriteLine("3. Çıkış");
                       Console.ReadKey();
                       break;

                       Console.ReadKey();
               
               }

           }
        
    }
}
