using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();
            PesawatTempur pesTem = new PesawatTempur();

            pesawat.Nama = "Helly";
            pesawat.JumlahRoda = 3;
            pesawat.Ketinggian = "1000 kaki";
            pesawat.JumlahPenumpang = "3 penumpang";

            pesTem.Nama = "AZ500TPU";
            pesTem.JumlahRoda = 5;
            pesTem.Ketinggian = "200 kaki";
            pesTem.JumlahPenumpang = "2 penumpang plus kopilot dan assistance";

            pesawat.terbang();
            pesTem.terbangtinggi();
            Console.Read();
        }
    }
}
