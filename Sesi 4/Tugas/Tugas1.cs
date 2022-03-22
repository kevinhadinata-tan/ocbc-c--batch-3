using System;

public class Tugas1
{
    public static void Main(String[] args)
    {
        string[] huruf = { "A", "B", "C", "D", "E"};
        int spasi;
        int panjang_huruf = huruf.Length;

        Console.WriteLine("Panjang huruf: {0}", panjang_huruf);
        
        for (int i = 1; i <= panjang_huruf; i++)
        {
            for (spasi = 1; spasi <= (panjang_huruf - i); spasi++)
            {
                Console.Write(" ");
            }

            for (int indeks_huruf = 0; indeks_huruf < i; indeks_huruf++)
            {
                Console.Write(huruf[indeks_huruf]);
            }

            for (int balik = (i - 1); balik >= 1; balik--)
            {
                Console.Write(huruf[balik - 1]);
            }

            Console.WriteLine();
        }
    }
}