using System;

public class Data
{
    public string nama_orang;

    public double noTelp;

    public void print(string nama)
    {
        this.nama_orang = nama;
        Console.WriteLine("Namanya adalah : {0}", this.nama_orang);
    }

    public void print(double nomor)
    {
        this.noTelp = nomor;
        Console.WriteLine("Nomor HP : {0}", this.noTelp);
    }
}