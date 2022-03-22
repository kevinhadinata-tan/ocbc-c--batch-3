using System;

public class Tugas4
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number: ");
        int nomor = int.Parse(Console.ReadLine());
        int hasil = 0, temp;

        while (nomor != 0)     
        {      
            temp = nomor % 10;        
            hasil = hasil * 10 + temp;      
            nomor /= 10;      
        }

        Console.WriteLine("Reversed Number: {0}", hasil);
    }
}