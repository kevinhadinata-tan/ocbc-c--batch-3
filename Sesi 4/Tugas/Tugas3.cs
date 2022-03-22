using System;

public class Tugas3
{
    public static void Main(String[] args)
    {
        int hasil = 0;

        Console.Write("Enter any Number: ");
        int nomor = int.Parse(Console.ReadLine());
        int i = nomor;

        do
        {
            if (hasil == 0) hasil = nomor;
            else hasil *= nomor;
            nomor--;
        } while (nomor > 0);

        Console.Write("Factorial of {0} is: {1}", i, hasil);
        Console.WriteLine();
    }
}