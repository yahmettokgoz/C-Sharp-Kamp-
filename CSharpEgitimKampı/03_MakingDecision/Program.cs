using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.WriteLine("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}
            //Console.Read();

            //string capital, country;
            //Console.WriteLine("Başkenti giriniz: ");
            //capital = Console.ReadLine();
            //Console.WriteLine("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital=="ankara" & country=="türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi");
            //}

            //int number;
            //Console.WriteLine("Sayı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number==5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result="Hata";
            //Console.WriteLine("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84 & average <= 100)
            //{
            //    result = "Sonuç çok iyi";
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.WriteLine("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city=="adana" | city=="ankara" | city=="bursa" | city=="trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.WriteLine("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username!="admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz!");
            //}

            #endregion

            #region Mod İşlemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.WriteLine("Lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("1.sayının 2.sayıya bölümünden kalan: " + result);

            //Console.WriteLine("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number%2==0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char team;
            //Console.WriteLine("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if (team=='g' | team=='G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team=='b' | team=='B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            // if (team=='f' | team=='F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** C Sharp Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("------------------------------------");

            //string menuItem;
            //Console.WriteLine("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();
            //if (menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri soslu tavuk");
            //    Console.WriteLine("2-Kızartma tabağı");
            //    Console.WriteLine("3-Fasulye pilav");
            //    Console.WriteLine("4-Fırında somon");
            //    Console.WriteLine("5-Patlıcan musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");



            //}
            //if (menuItem=="2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek çorbası");
            //    Console.WriteLine("2-Tarhana çorbası");
            //    Console.WriteLine("3-Tavuk suyu çorbası");
            //    Console.WriteLine("4-Ezogelin çorbası");
            //    Console.WriteLine("5-Domates çorbası");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Sucuklu pizza");
            //    Console.WriteLine("2-Ton balıklı pizza");
            //    Console.WriteLine("3-Akdeniz pizza");
            //    Console.WriteLine("4-Margarita pizza");
            //    Console.WriteLine("5-Tavuklu pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Fanta");
            //    Console.WriteLine("3-Meyve suyu");
            //    Console.WriteLine("4-Ayran");
            //    Console.WriteLine("5-Şalgam");
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Güllü muhallebi");
            //    Console.WriteLine("4-Sütlaç");
            //    Console.WriteLine("5-Bal kabağı tatlısı");
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //}


            #endregion

            #region Switch Case
            //Console.WriteLine("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı veri girişi"); break;


            //}
            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;
            //Console.WriteLine("1.Sayıyı giriniz :");
            //number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2.Sayıyı giriniz :");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result); break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result); break;
            //    case 'x':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result); break;
            //    case '%':
            //        result = number1 % number2;
            //        Console.WriteLine("Bölüm: " + result); break;


            //}

            #endregion














        }
    }
}
