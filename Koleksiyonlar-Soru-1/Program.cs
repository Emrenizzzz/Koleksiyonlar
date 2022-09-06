using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;
            uint[] numbers = null;
            do
            {
                Console.WriteLine("Lütfen aralarında boşluk bırakarak 20 adet pozitif sayı giriniz.");
                isTrue = true;
                try
                {
                    numbers = Console.ReadLine().Split(' ').Select(uint.Parse).ToArray();

                }
                catch (FormatException e)
                {

                    Console.WriteLine("Numerik olmayan bir değer girdiniz!");
                    isTrue = false;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Negatif bir değer girdiniz!");
                    isTrue=false;
                }
            } while (!isTrue);

            List<int> asal = new List<int>();
            List<int> asalolmayan = new List<int>();
            
            foreach(int number in numbers)
            {
                int sayac = 0;
                if(number == 2)
                {
                    asal.Add(number);
                }else if(number == 1)
                {
                    asalolmayan.Add(number);
                }
                else
                {
                    for(int i = 2; i < number; i++)
                    {
                        if(number % i == 0)
                        {
                            sayac++;
                        }
                    }

                    if(sayac > 0)
                    {
                        asalolmayan.Add(number);
                    }
                    else
                    {
                        asal.Add(number);
                    }
                }
            }



            asalolmayan.Sort();
            asalolmayan.Reverse();
            Console.WriteLine("** ASAL OLMAYAN SAYILAR **");
            foreach(int number in asalolmayan)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Eleman sayısı: "+asalolmayan.Count);
            Console.WriteLine("Ortalaması: "+asalolmayan.Average());







            Console.WriteLine("** ASAL SAYILAR **");
            


            asal.Sort();
            asal.Reverse();
            foreach (int number in asal)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Eleman sayısı: " + asal.Count);
            Console.WriteLine("Ortalaması: " + asal.Average());
        }
    }
}
