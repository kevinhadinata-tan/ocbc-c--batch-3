using System;

public class Data6
{
    public static void Main(String[] args)
    {
        int[] angka = new int[10];

        Console.WriteLine("Panjang array angka adalah " + angka.length);

        for (int i = 0; i < angka.Length; i++)
        {
            angka[i] = i * i;
        }

        Console.Write("Berikut adalah array angka: ");

        for (int i = 0; i < angka.Length; i++)
        {
            Console.Write(angka[i] + " ");
        }

        Console.WriteLine();
        Console.ReadLine();
    }
}