using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.78;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("-------- Elma Birim Fiyatı: " + applePrice + "TL");
            //Console.WriteLine("-------- Portakal Birim Fiyatı: " + orangePrice + "TL");
            //Console.WriteLine("-------- Çilek Birim Fiyatı: " + strawberryPrice + "TL");
            //Console.WriteLine("-------- Patates Birim Fiyatı: " + potatoPrice + "TL");
            //Console.WriteLine("-------- Domates Birim Fiyatı: " + tomatoPrice + "TL");

            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyatı: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyatı: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyatı: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyatı: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Tutarı: " + shoppingTotalPrice + "TL");



            #endregion

            #region Char Değişkenler

            // ABCDEFGH
            // DEF...
            // TOPLANTI SAAT 20:00'DE
            // ' '

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu SoyAdı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.WriteLine("İl Bilgisi: ");
            //passengerCity=Console.ReadLine();

            //Console.WriteLine("Yolcu Yaşı: ");
            //passengerAge=Console.ReadLine();

            //Console.WriteLine("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber=Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber +"Yolcu Adı: " + passengerName + " /" + " Yolcu SoyAdı: " + passengerSurname + passengerDistrict + " / " + passengerCity + " / " + passengerAge );

            //Console.Read();
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC125D
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 2000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.WriteLine("Lütfen aldığınız ayakkabı sayısınız giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısınız giriniz: ");
            //computerCount= int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız sandalye sayısınız giriniz: ");
            //chairCount= int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız televizyon sayısınız giriniz: ");
            //tvCount= int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice + "TL");

            //Console.ReadKey();
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.WriteLine("Lütfen 1.sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2.sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 3.sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3)/3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız: " + result);
            //Console.Read();

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.Write("Seçtiğiniz cinsiyet: " + gender);
            //Console.Read();
            #endregion



        }
    }
}
