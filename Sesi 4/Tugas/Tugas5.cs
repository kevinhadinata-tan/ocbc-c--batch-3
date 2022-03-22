using System;

public class Tugas5
{
    public static void Main(String[] args)
    {
        string nomor;
        Console.Write("Enter the Number= ");
        nomor = Console.ReadLine();

        char[] arr = nomor.ToCharArray();

        for (int x = 0; x < arr.Length; x++)
        {
            if (nomor[x] == '0') Console.Write("zero ");
            if (nomor[x] == '1') Console.Write("one ");
            if (nomor[x] == '2') Console.Write("two ");
            if (nomor[x] == '3') Console.Write("three ");
            if (nomor[x] == '4') Console.Write("four ");
            if (nomor[x] == '5') Console.Write("five ");
            if (nomor[x] == '6') Console.Write("six ");
            if (nomor[x] == '7') Console.Write("seven ");
            if (nomor[x] == '8') Console.Write("eight ");
            if (nomor[x] == '9') Console.Write("nine ");
        }
        Console.WriteLine("");
    }
}