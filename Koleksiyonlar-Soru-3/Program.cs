using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle giriniz.");
            string cumle = Console.ReadLine().Trim();
            char[] chars = new char[cumle.Length];
            string sesliler = "aAeEIıİiOoÖöÜüUu";
            int sayi = 0;
            for(int i = 0; i < cumle.Length; i++)
            {
                if (sesliler.Contains(cumle[i])){
                    chars[sayi] = cumle[i];
                    sayi++;
                }
            }
            
            foreach(char c in chars)
            {
                Console.Write(c);
            }
            
        }
    }
}
