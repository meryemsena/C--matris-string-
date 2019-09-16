using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim;
            do
            {
                Console.Write("..::  İşlemler  ::..\n 1-Matris İşlemleri \n 2-String İşlemleri \n 3-Çıkış \n Seçiminiz: ");
                secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("..:: Matris İşlemleri ::.. \n Matrisin satır sayısını giriniz(1-10 arasında):");
                        int satir = Convert.ToInt32(Console.ReadLine());
                        int sutun = satir;
                        if (satir < 10)
                        {
                            int[,] matris = new int[satir, sutun];
                            for (int i = 0; i < satir; i++)
                            {
                                for (int j = 0; j < sutun; j++)
                                {
                                    Console.Write("[{0},{1}]=", i + 1, j + 1);
                                    matris[i, j] = Convert.ToInt32(Console.ReadLine());
                                }
                            }
                            Console.WriteLine("Matris: ");

                            for (var i = 0; i < satir; i++)
                            {
                                for (var j = 0; j < sutun; j++)
                                {
                                    Console.Write(" " + matris[i, j] + " ");
                                }

                                Console.WriteLine();
                            }
                            Console.Write("1-Satir En Buyuk\n2-Satir Toplam \nSeçiminiz:");
                            int secim2 = Convert.ToInt32(Console.ReadLine());
                            switch (secim2)
                            {
                                case 1:
                                    Console.WriteLine("Sonuç:");
                                    for (int a = 0; a < satir; a++)
                                    {
                                        int buyuk = matris[a, 0];
                                        for (int b = 1; b < sutun; b++)
                                        {
                                            if (buyuk < matris[a, b])
                                            {
                                                buyuk = matris[a, b];
                                            }
                                        }
                                        Console.Write("{0} ", buyuk);
                                    }
                                    Console.WriteLine("\nDevam etmek için tıklayınız");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 2:
                                    Console.WriteLine("Sonuç:");
                                    for (int y = 0; y < satir; y++)
                                    {
                                        int toplam = 0;
                                        for (int x = 0; x < sutun; x++)
                                        {
                                            toplam = toplam + matris[y, x];
                                        }
                                        Console.Write(" " + toplam + " ");
                                    }
                                    Console.WriteLine("\nDevam etmek için tıklayınız");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Hatalı Seçim\nDevam etmek için tıklayınız");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı satır sayısı girdiniz");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("..:: String İşlemleri ::.. \nİşlem yapılacak stringi giriniz:");
                        string cumle = (Console.ReadLine());
                        Console.Write("İstenen harf:");
                        string harf = (Console.ReadLine());

                        int index = cumle.IndexOf(harf);
                        int sayi = 0, sayi1 = 0, sayi2 = 0;

                        sayi1 = index;
                        while (index != -1)
                        {
                            sayi2 = index;
                            index = cumle.IndexOf(harf, index + 1);
                            sayi++;

                        }
                        if (sayi >= 2)
                        {
                            Console.Write("1-Ara Metni Tersten Yaz\n2-Ara Metni Tekrarlı Yaz\nSeçiminiz:");
                            int secim3 = Convert.ToInt32(Console.ReadLine());
                            switch (secim3)
                            {
                                case 1:
                                    for (int i = sayi2 - 1; i > sayi1; i--)
                                    {
                                        Console.Write(cumle[i]);
                                    }
                                    Console.WriteLine("\nDevam etmek için tıklayınız");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 2:
                                    for (int t = 0; t < 5; t++)
                                    {
                                        for (int i = sayi1 + 1; i < sayi2; i++)
                                        {
                                            Console.Write(cumle[i]);
                                        }
                                        Console.WriteLine("\n");
                                    }
                                    Console.WriteLine("Devam etmek için tıklayınız");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Hatalı Seçim\nDevam etmek için tıklayınız");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        }
                        else {
                            Console.WriteLine("Cümle içerisinde aranan harf iki kez geçmelidir.\nDevam etmek için tıklayınız");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Çıkış yapılıyor.\nDevam etmek için tıklayınız");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Hatalı Seçim\nDevam etmek için tıklayınız");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (secim != 3);

        }
    }
}