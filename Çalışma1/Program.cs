using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1,sayi2,sonuc = 0;
            string islem;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("JagBjörn'ın Hesap Makinesi");
            Console.ResetColor();

            Console.WriteLine();

            ahmet:

            Console.Write("1. Sayı:");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. Sayı:");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Yapmak İstediğiniz İşlem?");
            Console.WriteLine("*Lütfen Aşağıda Belirtilen Sembolleri Kullanarak İşleminizi Seçiniz*");
            Console.WriteLine();
            Console.WriteLine("              + (TOPLAMA)");
            Console.WriteLine("              - (ÇIKARMA)");
            Console.WriteLine("              * (ÇARPMA)");
            Console.WriteLine("              / (BÖLME)");
            Console.WriteLine();
            islem = Convert.ToString(Console.ReadLine());

            if (islem == "+" || islem == "-" || islem == "*" || islem == "/")

            {
                if(islem == "+")
                {
                    sonuc = sayi1 + sayi2;
                }

                else if(islem == "-")
                {
                    sonuc = sayi1 - sayi2;
                }

                else if(islem == "*")
                {
                    sonuc = sayi1 * sayi2;
                }

                else if(islem == "/")
                {
                    sonuc = sayi1 / sayi2;
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("İşlem Sonucu:" + sonuc.ToString());
                Console.ResetColor();
            } 

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hatalı İşlem");
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Yeni İşlem");
            Console.ResetColor();
            goto ahmet;
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}