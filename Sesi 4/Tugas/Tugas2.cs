using System;

public class Tugas2
{
    public static void Main(String[] args)
    {
        int nomor, spasi;

        Console.Write("Enter the Range : ");

        nomor = int.Parse(Console.ReadLine());

        spasi = nomor - 1;

        for (int i = 1; i <= nomor; i++)
        {
            for (spasi = 1; spasi <= (nomor - i); spasi++)
            {
                Console.Write(" ");
            }

            for (int indeks_nomor = 1; indeks_nomor <= i; indeks_nomor++)
            {
                Console.Write(indeks_nomor);
            }

            for (int balik = (i - 1); balik >= 1; balik--)
            {
                Console.Write(balik);
            }

            Console.WriteLine();
        }
    }
}