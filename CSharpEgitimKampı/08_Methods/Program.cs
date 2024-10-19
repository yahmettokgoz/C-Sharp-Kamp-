using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer----> Listele , ekle , sil , güncelle
            //Void 

            //void customerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Hakan Yıldız");
            //    Console.WriteLine("Ahmet Yıldız");
            //    Console.WriteLine("Barış Yıldız");

            //}

            //customerList();

            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //sum();


            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName){
            //    Console.WriteLine(customerName);
            //}
            //Console.WriteLine("Ahmet Tokgöz");


            //void CustomerCard(string name , string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //CustomerCard("Ahmet","Tokgöz");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int number1 , int number2 , int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(1,2,3);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Ahmet Yusuf Tokgöz";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ahmet";
            //    string surName = "Tokgöz";
            //    return name + " " + surName;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital , string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x,y,z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti giriniz:  ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1 , int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(3,5));
            //Console.WriteLine(Sum(895, 1025));


            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student , int exam1 , int exam2 , int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result>=50)
            //    {
            //        return student +  " isimli öğrenci sınavı geçti" + "Ortalama: " + " " +result;
            //    }
            //    else
            //    {
            //        return student + " isimli öğrenci sınavı geçemedi" + "Ortalama: " + " " + result;
            //    }

            //}

            //Console.WriteLine(ExamResult("Ahmet" , 25,50,70));

            #endregion
           
        }
    }
}
