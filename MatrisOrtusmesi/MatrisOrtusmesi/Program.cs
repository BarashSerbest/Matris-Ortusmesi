using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ImageAlignment
{
    public static void Main()
    {
        // Giriş resimleri img1 ve img2'nin boyutunu n x n olarak tanımlama.
        int boyut = 3;
        int[,] img1 = { { 0, 0, 1 }, { 0, 1, 0 }, { 1, 0, 0 } };
        int[,] img2 = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

        // img1'i tüm olası yönlere kaydırarak img1'i img2 ile karşılaştırma.
        int maksimumOrtusme = 0;
        int enIyiKaydirmaRow = 0, enIyiKaydirmaCol = 0;
        for (int kaydirmaRow = -boyut + 1; kaydirmaRow < boyut; kaydirmaRow++)
        {
            for (int kaydirmaCol = -boyut + 1; kaydirmaCol < boyut; kaydirmaCol++)
            {
                int ortusme = ComputeOverlap(img1, img2, kaydirmaRow, kaydirmaCol);
                if (ortusme > maksimumOrtusme)
                {
                    maksimumOrtusme = ortusme;
                    enIyiKaydirmaRow = kaydirmaRow;
                    enIyiKaydirmaCol = kaydirmaCol;
                }
            }
        }

        // En iyi örtüşmeyi sağlamak için img1'i kaydırın.
        img1 = ShiftImage(img1, enIyiKaydirmaRow, enIyiKaydirmaCol);

        // Hizalanan resimleri döndürün.
        Console.WriteLine("Hizalanan img1:");
        PrintImage(img1);
        Console.WriteLine("Hizalanan img2:");
        PrintImage(img2);
    }
    public static void PrintImage(int[,] img)
    {
        int boyut = img.GetLength(0);
        for (int i = 0; i < boyut; i++)
        {
            for (int j = 0; j < boyut; j++)
            {
                Console.Write(img[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // img1'i kaydirmaRow ve kaydirmaCol kadar kaydırarak img1 ve img2 arasındaki örtüşmeyi hesaplar.
    public static int ComputeOverlap(int[,] img1, int[,] img2, int kaydirmaRow, int kaydirmaCol)
    {
        int ortusme = 0;
        int boyut = img1.GetLength(0);
        for (int i = 0; i < boyut; i++)
        {
            for (int j = 0; j < boyut; j++)
            {
                int row = i - kaydirmaRow;
                int col = j - kaydirmaCol;
                if (row >= 0 && row < boyut && col >= 0 && col < boyut && img1[row, col] == img2[i, j])
                {
                    ortusme++;
                }
            }
        }
        return ortusme;
    }

    // Resmi shiftRow ve shiftCol kadar kaydırır.
    public static int[,] ShiftImage(int[,] img, int kaydirmaRow, int kaydirmaCol)
    {
        int n = img.GetLength(0);
        int[,] kaydirilmisImg = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int row = i + kaydirmaRow;
                int col = j + kaydirmaCol;
                if (row >= 0 && row < n && col >= 0 && col < n)
                {
                    kaydirilmisImg[row, col] = img[i, j];
                }
            }
        }
        return kaydirilmisImg;
    }
}

