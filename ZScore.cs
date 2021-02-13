using System;
using System.Collections.Generic;

namespace ZScore
{
    class ZScore
    {
        
        static void Main(string[] args)
        {
            List<double> sayiDizisi = new List<double>();
            double sayi;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Sayi{0}: ", i);
                sayi = Convert.ToDouble(Console.ReadLine());
                sayiDizisi.Add(sayi);
            }
            Console.WriteLine(" ");


            double ort = ortalama(sayiDizisi);
            Console.WriteLine("Ortalama : " + ort);

            double ssapma = standart(sayiDizisi);
            Console.WriteLine("Standart Sapma : " + ssapma);
            Console.WriteLine(" ");


            foreach (double i in sayiDizisi)
            {
                double zscore = (i - ort) / ssapma;
                Console.WriteLine("ZScore: " + zscore);
            }
            
        }




        static double ortalama(List<double> dizi) // Ortalama
        {
            double toplam = 0;
            for (int i = 0; i < dizi.Count; i++)
                toplam += dizi[i];
            return toplam / dizi.Count;
        }
        static double standart(List<double> dizi) // Standart Sapma
        {
            double ort = ortalama(dizi);
            double toplam = 0.0;
            for (int i = 0; i < dizi.Count; i++)
                toplam += Math.Pow((dizi[i] - ort), 2);
            return Math.Sqrt(toplam / (dizi.Count - 1));
        }
    }
}
