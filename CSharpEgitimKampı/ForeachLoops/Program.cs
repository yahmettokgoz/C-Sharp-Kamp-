using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //Foreach(1;2;3;4)

            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //4:Liste , Koleksiyon , Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string  x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 86, 12, 40, 59, 74, 15 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 86, 12, 40, 59, 74, 15 };
            //foreach (int number in numbers)
            //{
            //    if (number%2==0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 86, 12, 40, 59, 74, 15 };
            //int total =0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            // Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("Sınıfınızda kaç öğrenci var?");
            int studentCount = int.Parse(Console.ReadLine());

            //Öğrenci isimlerini ne not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{i+1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();
                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi


            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"{studentNames[i]} isimli öğrencinin {j+1}. sınav notunu giriniz: ");
                double value = double.Parse(Console.ReadLine());
                totalExamResult += value;
            }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult/3;

            }

            //Öğrencilerin ortalaması ve geçip kalma durumları

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine($"{studentNames[i]} isimli öğrencinin ortalaması: {studentExamAvg[i]}");
                if (studentExamAvg[i]>=50)
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kaldı.");
                }
                Console.WriteLine("--------------------------------------------------");
            }
            
            #endregion
        }
    }
}
