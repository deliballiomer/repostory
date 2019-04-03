using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 0, sayi2 = 0;
            Console.Write("Sayı1'i giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı2'yi giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            sayi1 = sayi1 + sayi2;
            sayi2 = sayi1 - sayi2;
            sayi1 = sayi1 - sayi2;
            Console.WriteLine("Değişkenleri değiştirilen sayıların değeri: \nsayi1= {0}   sayi2=  {1}", sayi1, sayi2);
            Console.ReadKey();


        }
    }
}