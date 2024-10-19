using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Temel dizi örnekleri

            //2.4.6.8.
            //adana,ankara,bursa,çorum
            //sarı,kırmızı,mavi,gri
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Mavi";
            //colors[2] = "Turuncu";
            //colors[3] = "Sarı";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[5]); //Index hatası verir

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[5]); 

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki tüm elemanları listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 7, 5, 85, 41, 1026, 896, 257, 410,522 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', 'd','%','*' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArrays = { 47, 87, 41, 52, 63, 24, 29, 25, 21, 7, 9 };
            //int maxNumber = myArrays[0];

            //for (int i = 0; i < myArrays.Length; i++)
            //{
            //    if (myArrays[i]>maxNumber)
            //    {
            //        maxNumber = myArrays[i];
            //    }
            //}
            //Console.WriteLine("Dizideki en büyük eleman: " + maxNumber);

            //string[] persons = { "Ali", "Ayşe", "Ahmet", "Doğukan", "Ömer" };
            //Console.WriteLine(persons.Length); //Dizideki eleman sayısını yazdırır.

            //int[] numbers = { 45, 20, 14, 87, 89, 62, 63 };
            //Array.Sort(numbers);

            //for (int i = 0; i <numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 20, 14, 87, 89, 62, 63 };
            //Array.Reverse(numbers); //Diziyi tersten sıralar

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Methotlar

            //string[] customers = { "Ali", "Buse", "Elif", "Doğan" };
            //int index = Array.IndexOf(customers, "Elif");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 12, 85, 96, 35, 74, 10, 25 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() +" "+ "Dizinin en küçük elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan değer alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("----------------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 21, 42, 33, 54, 65,66,748,841,974 };
            //Console.WriteLine("Çift sayılar: ");
            

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%2==0)
            //    {
            //     Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("-------------------------------");

            //Console.WriteLine("Tek sayılar: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion


        }
    }
}
