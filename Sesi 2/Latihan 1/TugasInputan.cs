using System;

public class TugasInputan
{
    public static void Main(string[] args)
    {
        String username, password, jen_kel, status_nikah;
        int age;
        bool answer, status_jenkel;
        int nilai1, nilai2, nilai3, total_nilai;
        double rata_nilai;

        Console.WriteLine("=== Biodata Diri ===");
        Console.Write("Masukkan username: ");
        username = Console.ReadLine();

        Console.Write("Masukan password: ");
        password = Console.ReadLine();

        Console.Write("Masukan umur: ");
        age = int.Parse(Console.ReadLine());

        do
        {
            Console.Write("Masukan jenis kelamin: [Laki-Laki/Perempuan]");
            jen_kel = Console.ReadLine();
            status_jenkel = jen_kel == "Laki-Laki" || jen_kel == "Perempuan";
        } while (!status_jenkel);

        do
        {
            Console.Write("Masukan status nikah: [True/False]");
            status_nikah = Console.ReadLine();
            answer = status_nikah == "True" || status_nikah == "False";
        } while (!answer);
        
        Console.WriteLine("=== Aritmatika ===");
        Console.Write("Masukan nilai pertama");
        nilai1 = int.Parse(Console.ReadLine());
        Console.Write("Masukan nilai kedua");
        nilai2 = int.Parse(Console.ReadLine());
        Console.Write("Masukan nilai ketiga");
        nilai3 = int.Parse(Console.ReadLine());

        total_nilai = nilai1 + nilai2 + nilai3;

        rata_nilai =  total_nilai / 3;

        Console.WriteLine("=========================");
        
        Console.WriteLine($"Username: {username}");
        Console.WriteLine($"Umur: {age}");
        if (jen_kel == "Laki-Laki" || jen_kel == "Perempuan")
        {
            Console.WriteLine($"Jenis Kelamin: {jen_kel}");
        }
        if (status_nikah == "True" || status_nikah == "False")
        {
            Console.WriteLine($"Status nikah: {status_nikah}");
        }

        Console.WriteLine("=== Aritmatika ===");
        Console.WriteLine($"Total Nilai: {total_nilai}");
        Console.WriteLine($"Rata Nilai: {rata_nilai}");
    }
}