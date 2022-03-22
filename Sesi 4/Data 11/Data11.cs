using System;

public class Data11
{
    public static void Main(String[] args)
    {
        string stringawal = "C# membuat string mudah";

        string substr = stringawal.Substring(5, 12);

        Console.WriteLine("stringawal: " + stringawal);
        Console.WriteLine("substring: " + substr);
    }
}