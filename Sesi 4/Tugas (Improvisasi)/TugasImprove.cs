using System;

public class TugasImprove
{
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Aplikasi\n");
        Console.WriteLine("========\n");
        Console.WriteLine("1. Segitiga Alfabet");
        Console.WriteLine("2. Segitiga Angka");
        Console.WriteLine("3. Faktorial");
        Console.WriteLine("4. Balik Angka");
        Console.WriteLine("5. Convert Angka to String");
        Console.WriteLine("6. Balik Huruf");
        Console.WriteLine("7. Tentang Saya");
        Console.WriteLine("8. Keluar");
        Console.WriteLine("");
        Console.Write("Pilih? ");
    }

    static void Menu1()
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

    static void Menu2()
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

    static void Menu3() 
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
    static void Menu4() 
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
    static void Menu5() 
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
    static async void Menu6() 
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        char[] hasil = word.ToCharArray();
        
        Array.Reverse(hasil);
        
        Console.WriteLine("Reversed Word: {0}", new string(hasil));
    }
    static void Menu7() 
    {
        Console.WriteLine("Nama          : Kevin Hadinata");
        Console.WriteLine("Jenis Kelamin : Laki-Laki");
        Console.WriteLine("Alamat        : Pegangsaan Dua, Kelapa Gading");
        Console.WriteLine("Hobi          : Olahraga, Membaca buku, dan bermain games");
        Console.WriteLine("Umur          : 24 tahun");
        Console.WriteLine("Pekerjaan     : Full Stack Engineer");
        Console.WriteLine("Jurusan       : Teknik Informatika");
        Console.WriteLine("Nama Kampus   : Institut Bisnis dan Informatika Kwik Kian Gie\n");
    }
    public static void Main(String[] args)
    {
        int pilih;

        do
        {
            Menu();
            pilih = int.Parse(Console.ReadLine());

            if (pilih == 1)
            {
                Menu1();
                Console.Write("\nTekan sembarang tombol...");
                Console.ReadKey();
            }
            else if (pilih == 2)
            {
                Menu2();
                Console.Write("\nTekan sembarang tombol...");
                Console.ReadKey();
            }
            else if (pilih == 3)
            {
                Menu3();
                Console.Write("\nTekan sembarang tombol...");
                Console.ReadKey();
            }
            else if (pilih == 4)
            {
                Menu4();
                Console.Write("\nTekan sembarang tombol...");
                Console.ReadKey();
            }
            else if (pilih == 5)
            {
                Menu5();
                Console.Write("\nTekan sembarang tombol...");
                Console.ReadKey();
            }
            else if (pilih == 6)
            {
                Menu6();
                Console.Write("\nTekan sembarang tombol...");
                Console.ReadKey();
            }
            else if (pilih == 7)
            {
                Menu7();
                Console.Write("\nTekan sembarang tombol...");
                Console.ReadKey();
            }
            else if (pilih == 8) break;
        } while (true);
    }
}