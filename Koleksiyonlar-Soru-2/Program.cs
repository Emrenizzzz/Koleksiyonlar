using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;
            List<int> numbers = new List<int>();
            do
            {
                isTrue = true;
                Console.WriteLine("Lütfen aralarında boşluk olacak şekilde 20 adet sayı giriniz");
                try
                {
                    numbers = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Numerik olmayan bir değer girdiniz");
                    isTrue = false;
                }

            } while (!isTrue);
            
            numbers.Sort();
            List<int> buyuk = new List<int>();
            List<int> kucuk = new List<int>();
            buyuk.Add(numbers[numbers.Count-1]);
            buyuk.Add(numbers[numbers.Count-2]);
            buyuk.Add(numbers[numbers.Count-3]);

            kucuk.Add(numbers[0]);
            kucuk.Add(numbers[1]);
            kucuk.Add(numbers[2]);

            foreach (int number in buyuk)
                Console.WriteLine(number);

            foreach (int number2 in kucuk)
                Console.WriteLine(number2);


            Console.WriteLine("Küçüklerin ortalaması: "+kucuk.Average());
            Console.WriteLine("Büyüklerin ortalaması: "+buyuk.Average());
            double toplam = buyuk.Average() + kucuk.Average();
            Console.WriteLine("Ortalamaların toplamları: "+toplam);

        }
    }
}
