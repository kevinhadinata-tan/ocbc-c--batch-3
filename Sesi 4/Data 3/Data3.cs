using System;

public class Data3
{
    public static void Main(String[] args)
    {
        int baris, kolom;

        int[,] tabel = new int[3,4];

        for (baris = 0; baris < 3; ++baris)
        {
            for (kolom = 0; kolom < 4; ++kolom)
            {
                tabel[baris, kolom] = (baris * 4) + kolom + 1;
                Console.Write(tabel[baris, kolom] + " ");
            }

            Console.WriteLine();
        }
    }
}